using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using FaceRecognition.Model.FaceImagesModel;
using FaceRecognition.ViewModel;
using FaceDetection;
using System.Text;

namespace FaceRecognition.Controls
{
    public partial class TrainAndTestFaceControl : UserControl
    {
        #region Fields

        private bool _isTestImageSelected;
        private List<FaceImage> _selectedFaceImages;
        private List<FaceImage> _selectedTrainItems;
        private List<FaceImage> _selectedTestItems;

        #endregion //Fields

        #region Constructor

        public TrainAndTestFaceControl()
        {
            _isTestImageSelected = false;
            _selectedTrainItems = new List<FaceImage>();
            _selectedTestItems = new List<FaceImage>();
            TrainAndTestViewModel = new MainWindowViewModel();

            DataContext = TrainAndTestViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Public Properties

        public MainWindowViewModel TrainAndTestViewModel { get; set; }

        #endregion //Public Properties

        #region Event Handlers

        private void selectEvenImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var sbNumImage = new StringBuilder();

            foreach (FaceImage image in TrainAndTestViewModel.FaceImages)
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
                    TrainAndTestViewModel.TrainImages.Add(image);
            }
            TrainAndTestViewModel.NumberTrainFaceImages = TrainAndTestViewModel.TrainImages.Count;

            TrainAndTestViewModel.OnPropertyChanged("TrainImages");
            TrainAndTestViewModel.OnPropertyChanged("NumberTrainFaceImages");
        }

        private void selectOddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var sbNumImage = new StringBuilder();

            foreach (FaceImage image in TrainAndTestViewModel.FaceImages)
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
                    TrainAndTestViewModel.TestImages.Add(image);
            }
            TrainAndTestViewModel.NumberTestFaceImages = TrainAndTestViewModel.TestImages.Count;

            TrainAndTestViewModel.OnPropertyChanged("TestImages");
            TrainAndTestViewModel.OnPropertyChanged("NumberTestFaceImages");
        }

        private void DropTrainImage(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                _selectedFaceImages = e.Data.GetData("myFormat") as List<FaceImage>;
                TrainAndTestViewModel.NumberTrainFaceImages = _selectedFaceImages.Count;
                TrainAndTestViewModel.OnPropertyChanged("NumberTrainFaceImages");

                foreach (var faceImage in _selectedFaceImages)
                    TrainAndTestViewModel.TrainImages.Add(faceImage);
                TrainAndTestViewModel.OnPropertyChanged("TrainImages");
            }
        }

        private void DropTestImage(object  sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                _selectedFaceImages = e.Data.GetData("myFormat") as List<FaceImage>;
                TrainAndTestViewModel.NumberTestFaceImages = _selectedFaceImages.Count;
                TrainAndTestViewModel.OnPropertyChanged("NumberTestFaceImages");

                foreach (var faceImage in _selectedFaceImages)
                    TrainAndTestViewModel.TestImages.Add(faceImage);
                TrainAndTestViewModel.OnPropertyChanged("TestImages");
            }
        }

        private void DataBasesListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            busyControl.Visibility = Visibility.Visible;
            ThreadPool.QueueUserWorkItem(LoadData, sender);
        }

        private void delSelTrainItemsBtn_Click(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < _selectedTrainItems.Count; i++)
            {
                if (TrainAndTestViewModel.TrainImages.Contains(_selectedTrainItems[i]))
                {
                    TrainAndTestViewModel.TrainImages.Remove(_selectedTrainItems[i]);
                }
            }
        }

        private void delSelTestItemsBtn_Click(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < _selectedTestItems.Count; i++)
            {
                if (TrainAndTestViewModel.TestImages.Contains(_selectedTestItems[i]))
                {
                    TrainAndTestViewModel.TestImages.Remove(_selectedTestItems[i]);
                }
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

        #region Help Methods

        private void LoadData(object obj)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
            {
                TrainAndTestViewModel.SelectDb(((ListView)obj).SelectedIndex);
                busyControl.Visibility = Visibility.Hidden;
                busyControl.Visibility = Visibility.Collapsed;
            }));
        }

        #endregion //Help Methods
    }
}
