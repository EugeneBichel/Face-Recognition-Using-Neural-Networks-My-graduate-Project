using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.Properties;
using Utility;
using FaceRecognition.ViewModel;

namespace FaceRecognition.RecognitionMethods
{
    public abstract class FaceRecognitionMethodBase : ViewModelBase, IRecognitionMethod
    {
        #region Fields

        private RecognitionMethodsRepository _recognitionMethodsReposistory;

        #endregion //Fields

        #region Constructor

        protected FaceRecognitionMethodBase()
        {
            _recognitionMethodsReposistory = new RecognitionMethodsRepository();
            LoadTrainTestFaces();
        }

        #endregion //Constructor

        #region Abstract Methods

        public virtual bool Train()
        {
            throw new NotImplementedException();
        }
        public virtual object Recognize(object pattern)
        {
            throw new NotImplementedException();
        }

        #endregion //Abstract Methods
    }
}
