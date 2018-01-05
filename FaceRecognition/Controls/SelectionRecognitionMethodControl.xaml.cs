using System;
using System.Windows;
using System.Windows.Controls;
using FaceRecognition.ViewModel;
using FaceRecognition.RecognitionMethods;
using FaceRecognition.Controls.RecognizeMehodsControls;

namespace FaceRecognition.Controls
{
    public partial class SelectionRecognitionMethodControl : UserControl
    {
        #region Fields

        private SelectionRecognitionMethodViewModel _selectionRecMethodViewModel;
        private EigenFaceControl _eigenFaceControl;
        private NeuralNetworksControl _neuralNetworksControl;

        #endregion //Fields

        #region Events

        public static event EventHandler ClearRecognizedFacesPanelEvent;

        #endregion //Events

        #region Constructors

        public SelectionRecognitionMethodControl()
        {
            _selectionRecMethodViewModel = new SelectionRecognitionMethodViewModel();
            this.DataContext = _selectionRecMethodViewModel;

            InitializeComponent();
        }

        #endregion //Constructors

        #region Event Handlers

        private void RecognitionMethodsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectionRecMethodViewModel.RecognitionMethod = (e.Source as ListBox).SelectedItem as String;
            _selectionRecMethodViewModel.OnPropertyChanged("RecognitionMethod");
            SelectedMethodStackPanel.Visibility = Visibility.Visible;

            if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[Constants.EIGEN_FACE])
            {
                CreateControl(Constants.EIGEN_FACE);
            }
            else if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[Constants.ONE_LAYER_BACK_PROPAGATION])
            {
                CreateControl(Constants.ONE_LAYER_BACK_PROPAGATION);
            }
            else if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[Constants.TWO_LAYER_BACK_PROPAGATION])
            {
                CreateControl(Constants.TWO_LAYER_BACK_PROPAGATION);
            }
            else if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[Constants.THREE_LAYER_BACK_PROPAGATION])
            {
                CreateControl(Constants.THREE_LAYER_BACK_PROPAGATION);
            }

            _selectionRecMethodViewModel.SaveRecognitionMethod(_selectionRecMethodViewModel.RecognitionMethod);
        }

        #endregion //Event Handlers

        #region Create Controls

        private void CreateControl(int selectedMethodControl)
        {
            UserControl control = null;

            if (selectedMethodControl.Equals(Constants.EIGEN_FACE))
            {
                control = new EigenFaceControl();
            }
            else if (selectedMethodControl.Equals(Constants.ONE_LAYER_BACK_PROPAGATION))
            {
                control = new NeuralNetworksControl(Constants.ONE_LAYER_BACK_PROPAGATION);
            }
            else if (selectedMethodControl.Equals(Constants.TWO_LAYER_BACK_PROPAGATION))
            {
                control = new NeuralNetworksControl(Constants.TWO_LAYER_BACK_PROPAGATION);
            }
            else if (selectedMethodControl.Equals(Constants.THREE_LAYER_BACK_PROPAGATION))
            {
                control = new NeuralNetworksControl(Constants.THREE_LAYER_BACK_PROPAGATION);
            }

            if (TuningStackPanel.Children.Count > 0)
                TuningStackPanel.Children.RemoveRange(0, TuningStackPanel.Children.Count);

            TuningStackPanel.Children.Add(control);
            TuningStackPanel.Visibility = Visibility.Visible;
        }

        #endregion //Create Controls

        #region Private Methods

        private void OnClearRecognizedFacesPanel()
        {
            var handler = ClearRecognizedFacesPanelEvent;
            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        #endregion //Private Methods
    }
}
