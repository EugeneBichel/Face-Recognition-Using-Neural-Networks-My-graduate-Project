using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.NeuralNetworks.BackPropagation;
using FaceRecognition.Properties;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Utility;

namespace FaceRecognition.ViewModel.RecognitionMethodsViewModel
{
    public class NeuralNetworksViewModel : RecognizeMethodsViewModelBase
    {
        #region Fields

        //Neural Network Object With Output Type String
        private NeuralNetwork<string> _neuralNetwork;

        //Data Members Required For Neural Network
        private List<FaceImage> _trainingSet;

        private int _inputUnits;
        private int _hiddenUnits;
        private int _outputUnits;
        private double _error;
        private double _maxError;
        private int _iterations;
        private ObservableCollection<int> _layers;

        #endregion //Fields

        #region Constructor

        public NeuralNetworksViewModel()
        {
            _layers = new ObservableCollection<int>() { 1, 2, 3 };
            OnPropertyChanged("Layers");
            _maxError = Constants.MAX_ERROR;
            OnPropertyChanged("MaxError");
            SelectedLayer = 3;

            LoadTrainFaces();
            LoadTestFaces();

            InputUnits = (int)((double)(_trainFaces.Count) * .33);
            OnPropertyChanged("InputUnits");
            HiddenUnits = (int)((double)(_trainFaces.Count) * .11);
            OnPropertyChanged("HiddenUnits");

            var faces = new List<string>();

            foreach (FaceImage face in _testFaces)
            {
                if (faces.Contains(face.PersonId) == false)
                    faces.Add(face.PersonId);
            }

            OutputUnits = faces.Count;
            OnPropertyChanged("OutputUnits");

            GenerateTrainingSet();
            CreateNeuralNetwork();
        }
        public NeuralNetworksViewModel(int selectedMethod)
        {
            SelectedLayer = selectedMethod;
            _layers = new ObservableCollection<int>() { 1, 2, 3 };
            OnPropertyChanged("Layers");
            _maxError = 1.1;
            OnPropertyChanged("MaxError");

            LoadTrainFaces();
            LoadTestFaces();

            InputUnits = (int)((double)(_trainFaces.Count) * .33);
            OnPropertyChanged("InputUnits");
            HiddenUnits = (int)((double)(_trainFaces.Count) * .11);
            OnPropertyChanged("HiddenUnits");

            var faces = new List<string>();

            foreach (FaceImage face in _testFaces)
            {
                if (faces.Contains(face.PersonId) == false)
                    faces.Add(face.PersonId);
            }

            OutputUnits = faces.Count;
            OnPropertyChanged("OutputUnits");

            GenerateTrainingSet();
            CreateNeuralNetwork();
        }

        #endregion //Constructor

        #region Public Properties

        public ObservableCollection<int> Layers 
        {
            get
            {
                return _layers;
            }
            set
            {
                _layers = value;
                OnPropertyChanged("Layers");
            }
        }
        public int SelectedLayer { get; set; }
        public double MaxError
        {
            get
            {
                return _maxError;
            }
            set
            {
                _maxError = value;
                OnPropertyChanged("MaxError");
            }
        }
        public int InputUnits
        { 
            get
            {
                return _inputUnits;
            }
            set
            {
                _inputUnits = value;
                OnPropertyChanged("InputUnits");
            }
        }
        public int HiddenUnits
        {
            get
            {
                return _hiddenUnits;
            }
            set
            {
                _hiddenUnits = value;
                OnPropertyChanged("HiddenUnits");
            }
        }
        public int OutputUnits
        {
            get
            {
                return _outputUnits;
            }
            set
            {
                _outputUnits = value;
                OnPropertyChanged("OutputUnits");
            }
        }
        public double Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
                OnPropertyChanged("Error");
            }
        }
        public int Iterations
        {
            get
            {
                return _iterations;
            }
            set
            {
                _iterations = value;
                OnPropertyChanged("Iterations");
            }
        }


        #endregion //Public Properties

        #region Public Methods

        public override void Train()
        {
            var t = new Thread(ThreadPoolTrain);
            t.IsBackground = true;
            t.Start();

            if (_isTrainSuccess == true)
                _trainStatus = RecognizeMethodsViewModelBase.TrainResults[Constants.SUCCESS];
            else
                _trainStatus = TrainResults[Constants.FAILED];
            OnPropertyChanged("TrainStatus");

            SaveNeuronNet(SelectedLayer);
        }

        public override void Recognize()
        {
            try
            {
                using (_timer = new System.Timers.Timer(10))
                {
                    LoadTrainFaces();
                    LoadTestFaces();

                    _timer.Elapsed += new System.Timers.ElapsedEventHandler(_recTimer_Elapsed);
                    _timer.Enabled = true;
                    _timer.Start();

                    string MatchedHigh = "?", MatchedLow = "?";
                    double OutputValueHight = 0, OutputValueLow = 0;

                    foreach (FaceImage face in _testFaces)
                    {
                        _neuralNetwork.Recognize(face.VectorInNet, ref MatchedHigh, ref OutputValueHight, ref MatchedLow, ref OutputValueLow);
                        _imageClasses.Add(MatchedHigh);
                    }

                    GetRecognizeFace();
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed recognize process");
            }
        }

        #endregion //Public Methods

        #region Event Handlers

        private void _trainTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //TimeChanged(0.1);
            _trainTimeValue += 0.01;
            OnPropertyChanged("TrainTimeValue");
        }
        private void _recTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //TimeChanged(0.1);
            _recTimeValue += 0.01;
            OnPropertyChanged("RecognizeTimeValue");
        }
        #endregion //Event Handlers

        #region Private Methods

        private void CreateNeuralNetwork()
        {
            if (_trainingSet == null)
                throw new Exception("Unable to Create Neural Network As There is No Data to Train..");
            try
            {
                if (SelectedLayer == 1)
                {
                    _neuralNetwork = new NeuralNetwork<string>
                        (new BackPropagationOneLayer(_trainFaces[0].VectorInNet.Length, _trainFaces.Count), _trainingSet);
                }
                else if (SelectedLayer == 2)
                {
                    int InputNum = InputUnits;
                    _neuralNetwork = new NeuralNetwork<string>
                        (new BackPropagationTwoLayers(_trainFaces[0].VectorInNet.Length, InputNum, _trainFaces.Count), _trainingSet);

                }
                else if (SelectedLayer == 3)
                {
                    int InputNum = InputUnits;
                    int HiddenNum = HiddenUnits;

                    _neuralNetwork = new NeuralNetwork<string>
                        (new BackPropagationThreeLayers(_trainFaces[0].VectorInNet.Length, InputNum, HiddenNum, _trainFaces.Count), _trainingSet);
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
            }

            _neuralNetwork.IterationChanged +=
                new NeuralNetwork<string>.IterationChangedCallBack(neuralNetwork_IterationChanged);

            _neuralNetwork.MaximumError = MaxError;
        }

        private void GenerateTrainingSet()
        {
            //textBoxState.AppendText("Generating Training Set..");

            _trainingSet = new List<FaceImage>();
            foreach (FaceImage face in _trainFaces)
            {
                _trainingSet.Add(face);
            }

            //textBoxState.AppendText("Done!\r\n");
        }

        private void neuralNetwork_IterationChanged(object sender, NeuralEventArgs args)
        {
            UpdateError(args.CurrentError);
            UpdateIteration(args.CurrentIteration);
        }

        private void UpdateError(double error)
        {
            Error = error;
            OnPropertyChanged("Error");
        }
        private void UpdateIteration(int iter)
        {
            Iterations = iter;
            OnPropertyChanged("Iterations");
        }

        #endregion //Private Methods

        #region Save/Load NeuranNet

        private void SaveNeuronNet(int numLayers)
        {
            var fullNameFile = string.Empty;

            if (Constants.ONE_LAYER_BACK_PROPAGATION == numLayers)
            {
                fullNameFile = Strings.FileName_OneLayer_NeuronNet;
            }
            else if (Constants.TWO_LAYER_BACK_PROPAGATION == numLayers)
            {
                fullNameFile = Strings.FileName_TwoLayer_NeuronNet;
            }
            else if (Constants.THREE_LAYER_BACK_PROPAGATION == numLayers)
            {
                fullNameFile = Strings.FileName_ThreeLayer_NeuronNet;
            }

            try
            {
                var dataDir = Path.Combine(Helper.GetExecutedDirectory(), fullNameFile.Split('\\')[0]);
                if (Directory.Exists(dataDir) == false)
                    Directory.CreateDirectory(dataDir);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed create directory");
                return;
            }

            try
            {
                var neuronNetPath = Path.Combine(Helper.GetExecutedDirectory(), fullNameFile);

                Helper.SerializeObject(typeof(NeuralNetwork<string>), _neuralNetwork, neuronNetPath);

            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed save data");
            }
        }

        private void LoadNeuronNet(int numLayers)
        {
            var flFullName = string.Empty;

            if (Constants.ONE_LAYER_BACK_PROPAGATION == numLayers)
            {
                flFullName = Strings.FileName_OneLayer_NeuronNet;
            }
            else if (Constants.TWO_LAYER_BACK_PROPAGATION == numLayers)
            {
                flFullName = Strings.FileName_TwoLayer_NeuronNet;
            }
            else if (Constants.THREE_LAYER_BACK_PROPAGATION == numLayers)
            {
                flFullName = Strings.FileName_ThreeLayer_NeuronNet;
            }

            try
            {
                var dataDir = Path.Combine(Helper.GetExecutedDirectory(), flFullName.Split('\\')[0]);
                if (Directory.Exists(dataDir) == false)
                    Directory.CreateDirectory(dataDir);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed create directory");
                return;
            }

            try
            {
                var neuronNetPath = Path.Combine(Helper.GetExecutedDirectory(), flFullName);

                Helper.SerializeObject(typeof(NeuralNetwork<string>), _neuralNetwork, neuronNetPath);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed save data");
            }
        }

        #endregion //Save/Load NeuronNet

        #region ThreadPoolTrain

        private void ThreadPoolTrain()
        {
            try
            {
                using (_timer = new System.Timers.Timer(10))
                {
                    _timer.Elapsed += new System.Timers.ElapsedEventHandler(_trainTimer_Elapsed);
                    _timer.Enabled = true;
                    _timer.Start();
                    _isTrainSuccess = _neuralNetwork.Train();
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogin Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed train network");
            }
        }

        #endregion //ThreadPoolTrain
    }
}