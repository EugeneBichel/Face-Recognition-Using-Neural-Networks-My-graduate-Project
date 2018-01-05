using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FaceDetection;
using FaceImagesModel;
using FaceRecognition.Controls;
using FaceRecognition.RecognitionMethods.NeuralNetworks;
using FaceRecognition.ViewModel.CustomEventArgs;

namespace FaceRecognition.ViewModel
{
    public class PreprocessingPanelViewModel : ViewModelBase
    {
        #region Fields

        private ExtractFeatures _extractFeatures;
        private FdFaceDetection _faceDetectionRepository;

        #endregion //Fields

        #region Events

        public static event EventHandler<NumberTrainTestFacesEventArgs> SetNumberTrainTestFacesEvent;

        #endregion //Events

        #region Constructor

        public PreprocessingPanelViewModel()
        {
            _trainFaces = new ObservableCollection<FaceImage>();
            _testFaces = new ObservableCollection<FaceImage>();
            _trainImages = new ObservableCollection<FaceImage>();
            _testImages = new ObservableCollection<FaceImage>();
            _extractFeatures = new ExtractFeatures();
            _faceDetectionRepository = new FdFaceDetection();

            PreprocessingPanelControl.FaceImagesSavedEvent += new EventHandler(PreprocessingPanelControl_FaceImagesSavedEvent);
            PreprocessingPanelControl.FacesGotEvent += new EventHandler(PreprocessingPanelControl_FacesGotEvent);
        }

        #endregion //Constructor

        #region Event Handlers

        private void PreprocessingPanelControl_FaceImagesSavedEvent(object sender, EventArgs e)
        {
            SaveTrainFaces();
            SaveTestFaces();

            _extractFeatures.CreateVectors(_trainFaces, _testFaces);
            _extractFeatures.CreateVectorsAfterFFT();
            _extractFeatures.SaveTrainTestFaces();

            OnSetNumberTrainTestFaces();
        }

        private void PreprocessingPanelControl_FacesGotEvent(object sender, EventArgs e)
        {
            LoadTrainImages();
            LoadTestImages();

            SeparateTrainFaces();
            SeparateTestFaces();
        }

        #endregion //Event Handlers

        #region Private Methods

        private void SeparateTrainFaces()
        {
            if (_trainImages != null && _trainImages.Count > 0)
            {
                var images = new List<FaceImage>();
                foreach (FaceImage image in _trainImages)
                    images.Add(image);

                var trainFaces = _faceDetectionRepository.SeparateFaces(images, TrainTestFacesEnum.TrainFaces);
                foreach (FaceImage face in trainFaces)
                    _trainFaces.Add(face);
                OnPropertyChanged("TrainFaces");
            }
        }

        private void SeparateTestFaces()
        {
            if (_testImages != null && _testImages.Count > 0)
            {
                var images = new List<FaceImage>();

                foreach (FaceImage image in _testImages)
                    images.Add(image);

                var testFaces = _faceDetectionRepository.SeparateFaces(images, TrainTestFacesEnum.TestFaces);
                foreach (FaceImage face in testFaces)
                {
                    _testFaces.Add(face);
                    OnPropertyChanged("TestFaces");
                }
            }
        }

        private void OnSetNumberTrainTestFaces()
        {
            var handler = SetNumberTrainTestFacesEvent;
            if (handler != null)
            {
                var args = new NumberTrainTestFacesEventArgs(_trainFaces.Count, _testFaces.Count);
                handler(this, args);
            }
        }

        #endregion //Private Methods
    }
}