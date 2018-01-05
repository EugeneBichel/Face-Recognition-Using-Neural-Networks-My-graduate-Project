using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using FaceImagesModel;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    /// <summary>
    /// Interaction logic for SelectionTrainTestImages.xaml
    /// </summary>
    public partial class SelectionTrainTestImagesControl : UserControl
    {
        #region Fields

        private List<FaceImage> _selectedTrainItems;
        private List<FaceImage> _selectedTestItems;
        private List<FaceImage> _selectedFaceImages;

        private SelectionTrainTestImagesViewModel _selectionTrainTestImagesViewModel;

        #endregion //Fields

        #region Constructor

        public SelectionTrainTestImagesControl()
        {
            _selectedTrainItems = new List<FaceImage>();
            _selectedTestItems = new List<FaceImage>();
            _selectedFaceImages = new List<FaceImage>();
            _selectionTrainTestImagesViewModel = new SelectionTrainTestImagesViewModel();

            DataContext = _selectionTrainTestImagesViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Event Handlers

        private void selectEvenImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var sbNumImage = new StringBuilder();
            var images = new List<FaceImage>();

            foreach (FaceImage image in _selectionTrainTestImagesViewModel.Images)
            {
                int numImage = -1;
                sbNumImage.Clear();

                for (var i = 0; i < image.ShortName.Length; i++)
                {
                    if (image.ShortName[i] >= '0' && image.ShortName[i] <= '9')
                    {
                        sbNumImage.Append(image.ShortName[i]);
                    }
                }

                numImage = Convert.ToInt32(sbNumImage.ToString());
                if (numImage % 2 == 0)
                    images.Add(image);
            }
            _selectionTrainTestImagesViewModel.SetTrainImages(images);
        }

        private void selectOddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var sbNumImage = new StringBuilder();
            var images = new List<FaceImage>();

            foreach (FaceImage image in _selectionTrainTestImagesViewModel.Images)
            {
                int numImage = -1;
                sbNumImage.Clear();

                for (var i = 0; i < image.ShortName.Length; i++)
                {
                    if (image.ShortName[i] >= '0' && image.ShortName[i] <= '9')
                    {
                        sbNumImage.Append(image.ShortName[i]);
                    }
                }

                numImage = Convert.ToInt32(sbNumImage.ToString());
                if (numImage % 2 == 1)
                    images.Add(image);
            }

            _selectionTrainTestImagesViewModel.SetTestImages(images);
        }

        private void DropTrainImage(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                _selectedFaceImages = e.Data.GetData("myFormat") as List<FaceImage>;
                //_trainAndTestViewModel.NumberTrainFaceImages = _selectedFaceImages.Count;
                //_trainAndTestViewModel.OnPropertyChanged("NumberTrainFaceImages");

                _selectionTrainTestImagesViewModel.SetTrainImages(_selectedFaceImages);
            }
        }

        private void DropTestImage(object  sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                _selectedFaceImages = e.Data.GetData("myFormat") as List<FaceImage>;
                //TrainAndTestViewModel.NumberTestFaceImages = _selectedFaceImages.Count;
                //TrainAndTestViewModel.OnPropertyChanged("NumberTestFaceImages");

                _selectionTrainTestImagesViewModel.SetTestImages(_selectedFaceImages);
            }
        }

        private void delSelTrainItemsBtn_Click(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < _selectedTrainItems.Count; i++)
            {
                if (_selectionTrainTestImagesViewModel.TrainImages.Contains(_selectedTrainItems[i]))
                {
                    _selectionTrainTestImagesViewModel.TrainImages.Remove(_selectedTrainItems[i]);
                }

                _selectionTrainTestImagesViewModel.NumberTrainFaceImages = _selectionTrainTestImagesViewModel.TrainImages.Count;
                _selectionTrainTestImagesViewModel.OnPropertyChanged("NumberTrainFaceImages");
            }
        }

        private void delSelTestItemsBtn_Click(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < _selectedTestItems.Count; i++)
            {
                if (_selectionTrainTestImagesViewModel.TestImages.Contains(_selectedTestItems[i]))
                {
                    _selectionTrainTestImagesViewModel.TestImages.Remove(_selectedTestItems[i]);
                }

                _selectionTrainTestImagesViewModel.NumberTestFaceImages = _selectionTrainTestImagesViewModel.TestImages.Count;
                _selectionTrainTestImagesViewModel.OnPropertyChanged("NumberTestFaceImages");
            }
        }

        private void TestImageListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                _selectedTestItems.Add(item as FaceImage);
            }
            foreach (var item in e.RemovedItems)
            {
                //if (_selectedTestItems.Contains(item as FaceImage))
                    _selectedTestItems.Add(item as FaceImage);
            }

            if (_selectedTestItems.Count > 0)
                delSelTestItemsBtn.IsEnabled = true;
        }

        private void TrainImageListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                _selectedTrainItems.Add(item as FaceImage);
            }
            foreach (var item in e.RemovedItems)
            {
                //if (_selectedTrainItems.Contains(item as FaceImage))
                    _selectedTrainItems.Add(item as FaceImage);
            }

            if (_selectedTrainItems.Count > 0)
                delSelTrainItemsBtn.IsEnabled = true;
        }

        #endregion //Event Handlers
    }
}