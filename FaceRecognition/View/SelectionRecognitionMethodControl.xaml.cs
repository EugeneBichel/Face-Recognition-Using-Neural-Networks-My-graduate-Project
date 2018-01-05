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

            if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[FaceRecognition.RecognitionMethods.Constants.EigenFace])
            {
                CreateControl(FaceRecognition.RecognitionMethods.Constants.EigenFace);
            }
            else if (RecognitionMethodsListBox.SelectedValue == RecognitionMethodsRepository.Methods[FaceRecognition.RecognitionMethods.Constants.OneLayerBackPropagation])
            {
                CreateControl(FaceRecognition.RecognitionMethods.Constants.OneLayerBackPropagation);
            }

            _selectionRecMethodViewModel.SaveRecognitionMethod(_selectionRecMethodViewModel.RecognitionMethod);
        }

        #endregion //Event Handlers

        #region Create Controls

        private void CreateControl(int selectedMethodControl)
        {
            UserControl control = null;

            if (selectedMethodControl.Equals(FaceRecognition.RecognitionMethods.Constants.EigenFace))
            {
                control = new EigenFaceControl();
            }
            else if (selectedMethodControl.Equals(FaceRecognition.RecognitionMethods.Constants.OneLayerBackPropagation))
            {
                control = new NeuralNetworksControl();
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
