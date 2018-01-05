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

        #endregion //Fields

        #region Constructor

        public NeuralNetworksControl()
        {
            _neuralNetsViewModel = new NeuralNetworksViewModel();
            this.DataContext = _neuralNetsViewModel;

            InitializeComponent();
        }

        public NeuralNetworksControl(int selectedMethod)
        {
            _neuralNetsViewModel = new NeuralNetworksViewModel(selectedMethod);
            this.DataContext = _neuralNetsViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Handlers

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