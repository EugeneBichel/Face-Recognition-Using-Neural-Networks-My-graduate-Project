using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FaceImagesDataAccess;
using FaceImagesModel;
using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.ViewModel
{
    public class SelectionTrainTestImagesViewModel : ViewModelBase
    {
        #region Fields

        private FaceImagesRepository _imagesRepository;
        private ObservableCollection<string> _dataBases;
        private int _selectedDb;

        #endregion //Fields

        #region Constructor

        public SelectionTrainTestImagesViewModel()
        {
            _trainImages = new ObservableCollection<FaceImage>();
            _testImages = new ObservableCollection<FaceImage>();
            _imagesRepository = new FaceImagesRepository();
            _images = new ObservableCollection<FaceImage>();

            MainWindow.TrainAndTestDataSavedEvent += new EventHandler(MainWindow_TrainAndTestDataSavedEvent);
            SelectionDataBaseViewModel.SelectedDataBaseEvent += new EventHandler<SelectedFaceDbEventArgs>(SelectionDataBaseViewModel_SelectedDataBaseEvent);
        }

        #endregion //Constructor

        #region Public Properties

        public int NumberTrainFaceImages { get; set; }
        public int NumberTestFaceImages { get; set; }

        #endregion //Public Properties

        #region Event Handlers

        private void MainWindow_TrainAndTestDataSavedEvent(object sender, EventArgs e)
        {
            SaveTrainImages();
            SaveTestImages();
        }

        private void SelectionDataBaseViewModel_SelectedDataBaseEvent(object sender, SelectedFaceDbEventArgs e)
        {
            _selectedDb = e.SelectedId;
            GetFaceImages();
        }

        #endregion //Event Handlers

        #region Public Methods

        public void SetTrainImages(List<FaceImage> trainImages)
        {
            foreach(FaceImage image in trainImages)
            {
                _trainImages.Add(image);
            }
            OnPropertyChanged("TrainImages");
            NumberTrainFaceImages = TrainImages.Count;
            OnPropertyChanged("NumberTrainFaceImages");
        }

        public void SetTestImages(List<FaceImage> testImages)
        {
            foreach (FaceImage image in testImages)
            {
                _testImages.Add(image);
            }
            OnPropertyChanged("TestImages");
            NumberTestFaceImages = TestImages.Count;
            OnPropertyChanged("NumberTestFaceImages");
        }

        #endregion //Public Methods

        #region Private Methods

        private void GetFaceImages()
        {
            try
            {
                Images.Clear();
                foreach (FaceImage faceImage in _imagesRepository.ImageDataBases[_selectedDb].FaceImages)
                    _images.Add(faceImage);
                OnPropertyChanged("Images");
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;
            }
        }

        #endregion //Private Methods
    }
}
