using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using FaceImagesModel;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    /// <summary>
    /// Interaction logic for SelectionDataBase.xaml
    /// </summary>
    public partial class SelectionDataBaseControl : UserControl
    {
        #region Fields

        private SelectionDataBaseViewModel _selectionDataBaseViewModel;

        #endregion //Fields

        #region Constructor

        public SelectionDataBaseControl()
        {
            _selectionDataBaseViewModel = new SelectionDataBaseViewModel();
            DataContext = _selectionDataBaseViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Event Handlers

        private void DataBasesListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            busyControl.Visibility = Visibility.Visible;
            ThreadPool.QueueUserWorkItem(LoadData, sender);
        }

        #endregion //Event Handlers

        #region Help Methods

        private void LoadData(object obj)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
            {
                _selectionDataBaseViewModel.SelectDb(((ListView)obj).SelectedIndex);
                busyControl.Visibility = Visibility.Hidden;
                busyControl.Visibility = Visibility.Collapsed;
            }));
        }

        #endregion //Help Methods
    }
}
