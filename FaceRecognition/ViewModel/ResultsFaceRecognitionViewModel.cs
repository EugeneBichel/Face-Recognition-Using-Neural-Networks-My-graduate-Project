using System;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using FaceRecognition.RecognitionMethods.MethodModel;
using System.Collections.ObjectModel;
using FaceRecognition.RecognitionMethods;

namespace FaceRecognition.ViewModel
{
    public class ResultsFaceRecognitionViewModel:ViewModelBase
    {
        #region Fields

        private ObservableCollection<RecognitionMethodModel> _recMethods;
        private string _name;
        private double _recognitionPercent;
        private double _timeRec;
        private int _numTrainFaces;
        private int _numTestFaces;

        #endregion //Fields

        #region Events

        public static event EventHandler DrawResultTableEvent;

        #endregion //Events

        #region Constructor

        public ResultsFaceRecognitionViewModel()
        {
            _recMethods = new ObservableCollection<RecognitionMethodModel>();
            RecognizeMethodsViewModelBase.DrawRecongitionResultsEvent += new EventHandler<RecognizeEventArgs>(RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent);
            PreprocessingPanelViewModel.SetNumberTrainTestFacesEvent += new EventHandler<NumberTrainTestFacesEventArgs>(PreprocessingPanelViewModel_SetNumberTrainTestFacesEvent);
        }

        #endregion //Constructor

        #region Public Properties

        public ObservableCollection<RecognitionMethodModel> RecognitionMethods
        {
            get
            {
                return _recMethods;
            }
            set
            {
                _recMethods = value;
                OnPropertyChanged("RecognitionMethods");
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public double RecognitionPercent
        {
            get
            {
                return _recognitionPercent;
            }
            set
            {
                _recognitionPercent = value;
                OnPropertyChanged("RecognitionPercent");
            }
        }
        public double TimeRecognize
        {
            get
            {
                return _timeRec;
            }
            set
            {
                _timeRec = value;
                OnPropertyChanged("TimeRecognize");
            }
        }
        public int NumberTrainFaces
        {
            get { return _numTrainFaces; }
            set
            {
                _numTrainFaces = value;
                OnPropertyChanged("NumberTrainFaces");
            }
        }
        public int NumberTestFaces
        {
            get
            {
                return _numTestFaces;
            }
            set
            {
                _numTestFaces = value;
                OnPropertyChanged("NumberTestFaces");
            }
        }

        #endregion //Public Properties

        #region Event Handlers

        private void PreprocessingPanelViewModel_SetNumberTrainTestFacesEvent(object sender, NumberTrainTestFacesEventArgs e)
        {
            _numTrainFaces = e.NumberTrainFaces;
            OnPropertyChanged("NumberTrainFaces");
            _numTestFaces = e.NumberTestFaces;
            OnPropertyChanged("NumberTestFaces");
        }

        private void RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(object sender, RecognizeEventArgs e)
        {
            _name = e.MethodName;
            _timeRec = e.RecognizeTime;
            _recognitionPercent = e.PercentRecFaces;

            var method = new RecognitionMethodModel();
            method.Name = _name;
            method.RecognitionPercent = _recognitionPercent;
            method.TimeRecognize = _timeRec;

            var isContains = false;

            if (_recMethods.Count == 0)
                _recMethods.Add(method);
            else
            {
                foreach (RecognitionMethodModel recMethod in _recMethods)
                {
                    if (recMethod.Name.Equals(method.Name) == true)
                    {
                        isContains = true;
                        break;
                    }
                }
                if (isContains == false)
                    _recMethods.Add(method);
            }
            OnPropertyChanged("RecognitionMethods");

          //  OnDrawResultsTable();
        }

        #endregion //Event Handlers

        #region Raise Events

        private void OnDrawResultsTable()
        {
            var handler = DrawResultTableEvent;
            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        #endregion //Raise Events
    }
}