using System;
using System.Collections.Generic;
using System.IO;
using FaceRecognition.Properties;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Utility;
using System.Windows.Forms;

namespace FaceRecognition.RecognitionMethods
{
    public class RecognitionMethodsRepository
    {
        #region Fields

        public static readonly List<string> Methods;
        private string _selectedRecognitionMethod;

        #endregion //Fields

        #region Constrcutors

        static RecognitionMethodsRepository()
        {
            Methods = new List<string>() { "EigenFace", "OneLayerBackPropagation", "TwoLayerBackPropagation", "ThreeLayerBackPropagation" };
        }
        public RecognitionMethodsRepository()
        {
            LoadSelectedRecognitionMethod();
        }

        #endregion //Constructors

        #region Public Properties

        public string SelectedMethod
        {
            get 
            {
                return _selectedRecognitionMethod;
            }
            set 
            {
                _selectedRecognitionMethod = value;
            }
        }

        #endregion //Public Properties

        #region Private Methods

        private void LoadSelectedRecognitionMethod()
        {
            var recMethodsPath = string.Empty;

            try
            {
            var dataDir = Path.Combine(Helper.GetExecutedDirectory(), Strings.FileName_TrainFaces.Split('\\')[0]);
            if (Directory.Exists(dataDir) == false)
                Directory.CreateDirectory(dataDir);

            recMethodsPath = Path.Combine(Helper.GetExecutedDirectory(), Strings.FileName_SelectedRecognitionMethods);

            _selectedRecognitionMethod = (string)Helper.DeserializeObject(typeof(String), recMethodsPath);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Exception");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed load data from {0} file", recMethodsPath));
            }
        }

        #endregion //Private Methods
    }
}