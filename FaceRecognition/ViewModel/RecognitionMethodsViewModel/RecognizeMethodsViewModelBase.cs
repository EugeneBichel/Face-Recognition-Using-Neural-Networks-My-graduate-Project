using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods;
using FaceRecognition.ViewModel.CustomEventArgs;
using System.Timers;
using System.Windows.Forms;

namespace FaceRecognition.ViewModel.RecognitionMethodsViewModel
{
    public abstract class RecognizeMethodsViewModelBase : ViewModelBase
    {
        #region Static Fields

        protected static readonly Dictionary<int, string> TrainResults;

        #endregion //Static Fields

        #region Fields

        protected RecognitionMethodBase _faceRecognitionMethod;
        protected string _trainStatus;
        protected System.Timers.Timer _timer;
        protected double _trainTimeValue;
        protected double _recTimeValue;
        protected bool _isTrainSuccess;
        protected string _selectedMethod;

        #endregion //Fields

        #region Events

        //public static event EventHandler<TrainSuccessEventArgs> TrainEvent;
        public static event EventHandler<RecognizeEventArgs> DrawRecongitionResultsEvent;

        #endregion //Events

        #region Constructor

        protected RecognizeMethodsViewModelBase()
        {
            _imageClasses = new List<string>();
            _isTrainSuccess = false;
            SelectionRecognitionMethodViewModel.GetSelectedRecognizeMethodEvent += new EventHandler<RecognizeMethodEventArgs>(SelectionRecognitionMethodViewModel_GetSelectedRecognizeMethodEvent);
        }

        static RecognizeMethodsViewModelBase()
        {
            TrainResults = new Dictionary<int, string>();
            TrainResults.Add(Constants.SUCCESS, "Success");
            TrainResults.Add(Constants.FAILED, "Failed");
        }

        #endregion //Constructor

        #region Handlers

        private void SelectionRecognitionMethodViewModel_BeginRecognitionEvent(object sender, EventArgs e)
        {
            Recognize();
        }

        private void SelectionRecognitionMethodViewModel_GetSelectedRecognizeMethodEvent(object sender, RecognizeMethodEventArgs e)
        {
            _selectedMethod = e.SelectedMethod;
        }

        #endregion //Handlers

        #region Public Properties

        public string TrainStatus
        {
            get
            {
                return _trainStatus;
            }
            set
            {
                _trainStatus = value;
                OnPropertyChanged("TrainStatus");
            }
        }
        public double TrainTimeValue
        {
            get
            {
                return _trainTimeValue;
            }
            set
            {
                _trainTimeValue = value;
                OnPropertyChanged("TrainTimeValue");
            }
        }
        public double RecognizeTimeValue
        {
            get
            {
                return _recTimeValue;
            }
            set
            {
                _recTimeValue = value;
                OnPropertyChanged("RecognizeTimeValue");
            }
        }

        #endregion //Public Properties

        #region Protected Methods

        public abstract void Train();

        public abstract void Recognize();

        #endregion //Protected Methods

        #region Get Recognized Faces By Class

        protected void GetRecognizeFace()
        {
            if (_imageClasses.Count == 0)
            {
                MessageBox.Show("Test faces are not recognized", "Test faces are not recognized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _recognizedFaces = new ObservableCollection<FaceImage>();

            var faces = new List<string>();

            foreach (string personId in _imageClasses)
            {
                //foreach (FaceImage testImage in TestFaces)
                //{
                //    if (testImage.PersonId.Equals(personId))
                //        if (_recognizedFaces.Contains(testImage) == false)
                //            _recognizedFaces.Add(testImage);
                //}

                foreach (FaceImage trainImage in TrainFaces)
                {
                    if (trainImage.PersonId.Equals(personId))
                    {
                        _recognizedFaces.Add(trainImage);

                        if (faces.Count == 0)
                            faces.Add(trainImage.PersonId);
                        else if (faces.Count > 0 && faces.Contains(trainImage.PersonId) == false)
                        {
                            faces.Add(trainImage.PersonId);
                        }
                    }
                }
            }

            OnPropertyChanged("RecognizedFaces");

            SaveRecognizedFaces();

            double percent = 0;
            if (_testFaces.Count != 0)
                percent = ((double)faces.Count / (double)_testFaces.Count) * 100;

            OnDrawRecognizedFaces(percent);
        }

        #endregion //Get Recognized Faces By Class

        #region OnDrawRecognizedFaces

        protected void OnDrawRecognizedFaces(double percentRecFaces)
        {
            var handler = DrawRecongitionResultsEvent;
            if (handler != null)
            {
                var args = new RecognizeEventArgs(_selectedMethod, _recTimeValue, percentRecFaces);
                handler(this, args);
            }
        }

        #endregion //OnDrawRecognizedFaces
    }
}