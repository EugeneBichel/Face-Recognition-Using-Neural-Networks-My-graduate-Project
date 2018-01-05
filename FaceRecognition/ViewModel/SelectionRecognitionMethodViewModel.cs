using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;
using FaceRecognition.Properties;
using FaceRecognition.RecognitionMethods;
using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Utility;

namespace FaceRecognition.ViewModel
{
    public class SelectionRecognitionMethodViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<string> _recognitionMethods;
        private string _recognitionMethod;

        #endregion //Fields

        #region Events

        public static event EventHandler<RecognizeMethodEventArgs> GetSelectedRecognizeMethodEvent;

        #endregion //Events

        #region Constructors

        public SelectionRecognitionMethodViewModel()
        {
            _recognitionMethods = new ObservableCollection<string>();
            foreach (string method in RecognitionMethodsRepository.Methods)
                _recognitionMethods.Add(method);
        }

        #endregion //Constructors

        #region Public Properties

        public ObservableCollection<string> RecognitionMethods
        {
            get { return _recognitionMethods; }
            set
            {
                _recognitionMethods = value;
                OnPropertyChanged("RecognitionMethods");
            }
        }
        public string RecognitionMethod
        {
            get { return _recognitionMethod; }
            set
            {
                _recognitionMethod = value;
                OnPropertyChanged("RecognitionMethod");              
            }
        }
        public string TrainStatus { get; set; }

        #endregion //Public Properties

        #region Public Methods

        public void SaveRecognitionMethod(string selectedMethod)
        {
            CreateDataDir(Strings.FileName_SelectedRecognitionMethods);

            SaveMethod(Strings.FileName_SelectedRecognitionMethods);

            OnGetSelectedRecMethod();
        }

        #endregion //Public Methods

        #region Private Methods

        private void OnGetSelectedRecMethod()
        {
            var handler = GetSelectedRecognizeMethodEvent;
            if (handler != null)
            {
                var args = new RecognizeMethodEventArgs(_recognitionMethod);
                handler(this, args);
            }
        }

        private void SaveMethod(string name)
        {
            try
            {
                var recMethodsPath = Path.Combine(Helper.GetExecutedDirectory(), Strings.FileName_SelectedRecognitionMethods);
                Helper.SerializeObject(typeof(String), name, recMethodsPath);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"IO Policy");
                if (rethrow)
                    throw;
                MessageBox.Show("Failed save data");
            }
        }

        #endregion //Private Methods
    }
}