using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.NeuralNetworks.BackPropagation
{
    public class NeuralNetwork<T>
        where T : IComparable<T>
    {
        #region Fields

        private IBackPropagation _neuralNet;
        private double _maxError;
        private int _maxIter;
        private List<FaceImage> _trainingSet;

        #endregion //Fields

        #region Events

        public delegate void IterationChangedCallBack(object sender, NeuralEventArgs args);
        public event IterationChangedCallBack IterationChanged = null;

        #endregion //Events

        #region Constructor

        public NeuralNetwork(IBackPropagation IBackPro, List<FaceImage> trainingSet)
        {
            if (trainingSet == null)
                throw new ArgumentNullException("trainingSet");

            _maxError = Constants.MAX_ERROR;
            _maxIter = Constants.MAX_ITERATION;

            _neuralNet = IBackPro;
            _trainingSet = trainingSet;
            _neuralNet.InitializeNetwork(_trainingSet);
        }

        //for Serialization
        public NeuralNetwork()
        {

        }

        #endregion //Constructor

        #region Public Methods

        public bool Train()
        {
            double currentError = 0;
            int currentIteration = 0;
            NeuralEventArgs Args = new NeuralEventArgs();

            do
            {
                currentError = 0;
                foreach (FaceImage face in _trainingSet)
                {
                    _neuralNet.ForwardPropagate(face.VectorInNet, face.PersonId);
                    _neuralNet.BackPropagate();
                    currentError += _neuralNet.GetError();
                }

                currentIteration++;

                if (IterationChanged != null && currentIteration % 5 == 0)
                {
                    Args.CurrentError = currentError;
                    Args.CurrentIteration = currentIteration;
                    IterationChanged(this, Args);
                }

            } while (currentError > _maxError && currentIteration < _maxIter && !Args.Stop);

            if (IterationChanged != null)
            {
                Args.CurrentError = currentError;
                Args.CurrentIteration = currentIteration;
                IterationChanged(this, Args);
            }

            if (currentIteration >= _maxIter || Args.Stop)
                return false;//Training Not Successful

            return true;
        }

        public void Recognize(double[] input, ref string matchedHigh, ref double outputValueHight,
            ref string matchedLow, ref double outputValueLow)
        {
            _neuralNet.Recognize(input, ref matchedHigh, ref outputValueHight, ref matchedLow, ref outputValueLow);
        }

        public void SaveNetwork(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Create))
                {
                    var bf = new BinaryFormatter();
                    bf.Serialize(fs, _neuralNet);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed save network");
            }
        }

        public void LoadNetwork(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    var bf = new BinaryFormatter();
                    _neuralNet = (IBackPropagation)bf.Deserialize(fs);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Pocily");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed load network");
            }
        }

        public double MaximumError
        {
            get { return _maxError; }
            set { _maxError = value; }
        }

        public int MaximumIteration
        {
            get { return _maxIter; }
            set { _maxIter = value; }
        }

        #endregion //Public Methods
    }
}