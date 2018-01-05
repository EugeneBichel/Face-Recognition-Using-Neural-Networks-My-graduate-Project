using System;
using FaceRecognition.ViewModel;

namespace FaceRecognition.RecognitionMethods
{
    public abstract class RecognitionMethodBase : ViewModelBase, IRecognitionMethod
    {
        #region Fields

        private RecognitionMethodsRepository _recognitionMethodsReposistory;

        #endregion //Fields

        #region Constructor

        protected RecognitionMethodBase()
        {
            _recognitionMethodsReposistory = new RecognitionMethodsRepository();
            LoadTrainFaces();
            LoadTestFaces();
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
