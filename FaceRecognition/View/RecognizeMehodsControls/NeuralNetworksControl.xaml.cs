using System;
using System.Windows;
using System.Windows.Controls;
using FaceRecognition.NeuralNetworks.BackPropagation;
using FaceRecognition.ViewModel;
using FaceRecognition.ViewModel.RecognitionMethodsViewModel;

namespace FaceRecognition.Controls.RecognizeMehodsControls
{
    public partial class NeuralNetworksControl : RecognizeMethodControlBase
    {
        #region Fields

        private NeuralNetworksViewModel _neuralNetsViewModel;

        //For Asynchronized Programming Instead of Handling Threads
        private delegate bool TrainingCallBack();
        private AsyncCallback asyCallBack = null;
        private IAsyncResult res = null;

        private DateTime DTStart;

        #endregion //Fields

        #region Constructor

        public NeuralNetworksControl()
        {
            _neuralNetsViewModel = new NeuralNetworksViewModel();
            this.DataContext = _neuralNetsViewModel;

            InitializeComponent();

            LayersComboBox.SelectedValue = _neuralNetsViewModel.SelectedLayer;
        }

        #endregion //Constructor

        #region Handlers

        private void LayersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TrainButton_Click(object sender, RoutedEventArgs e)
        {
            OnSavedData();
            _neuralNetsViewModel.Train();
        }

        private void RecognizeButton_Click(object sender, RoutedEventArgs e)
        {
            OnRecognizePanelVisible();
            _neuralNetsViewModel.Recognize();
        }

        #endregion //Handlers
    }
}
