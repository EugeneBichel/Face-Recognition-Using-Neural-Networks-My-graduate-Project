using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using FaceImagesDataAccess;
using FaceImagesModel;
using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.ViewModel
{
    public class SelectionDataBaseViewModel : ViewModelBase
    {
        #region Fields
        
        private FaceImagesRepository _imagesRepository;
        private ObservableCollection<string> _dataBases;

        #endregion //Fields

        #region Events

        public static event EventHandler<SelectedFaceDbEventArgs> SelectedDataBaseEvent;

        #endregion //Events

        #region Constructor

        public SelectionDataBaseViewModel()
        {
            _imagesRepository = new FaceImagesRepository();
            _images = new ObservableCollection<FaceImage>();
            _dataBases = new ObservableCollection<string>();

            foreach (FaceDataBase dataBase in _imagesRepository.ImageDataBases)
                _dataBases.Add(dataBase.ShortName);
        }

        #endregion //Constructor

        #region Public Properties

        public int NumberFaceImages { get; set; }
        public ObservableCollection<string> DataBaseNames
        {
            get { return _dataBases; }
        }

        #endregion //Public Properties

        #region Public Methods

        public void SelectDb(int selectedFaceDb)
        {
            try
            {
                Images.Clear();
                foreach (FaceImage faceImage in _imagesRepository.ImageDataBases[selectedFaceDb].FaceImages)
                    _images.Add(faceImage);
                OnPropertyChanged("Images");

                NumberFaceImages = _images.Count;
                OnPropertyChanged("NumberFaceImages");
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"BisunessLogic Policy");
                if (rethrow)
                    throw;
            }
        }

        #endregion //Public Methods

        #region OnSelectedDataBase

        private void OnSelectedDataBase(int selectedId)
        {
            var handler = SelectedDataBaseEvent;
            if (handler != null)
            {
                var args = new SelectedFaceDbEventArgs(selectedId);
                handler(this, args);
            }
        }

        #endregion //OnSelectedDataBase
    }
}
