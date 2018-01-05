using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods;
using FaceRecognition.ViewModel.CustomEventArgs;

namespace FaceRecognition.ViewModel
{
    public class RecognizePanelViewModel : ViewModelBase
    {
        #region Constructors

        public RecognizePanelViewModel()
        {
            
        }

        #endregion //Constructors

        public void LoadTrainTestRecognizedFaces()
        {
            LoadTrainFaces();
            LoadTestFaces();
            LoadRecognizedFaces();
        }
    }
}