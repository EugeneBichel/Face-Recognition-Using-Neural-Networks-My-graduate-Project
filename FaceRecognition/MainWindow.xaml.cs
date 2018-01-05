using System;
using System.Windows;
using FaceRecognition.Controls;
using FaceRecognition.Controls.RecognizeMehodsControls;
using FaceRecognition.Properties;
using FaceRecognition.ViewModel;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using Utility;

namespace FaceRecognition
{
    public partial class MainWindow : Window
    {
        #region Events

        public static event EventHandler TrainAndTestDataSavedEvent;
        public static event EventHandler ImagesPreprocessedEvent;

        #endregion //Events

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            RecognizeMethodsViewModelBase.DrawRecongitionResultsEvent += new EventHandler<RecognizeEventArgs>(RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent);
            RecognizeMethodControlBase.RecognizePanelVisibleEvent += new EventHandler(RecognizeMethodControlBase_RecognizePanelVisibleEvent);
            PreprocessingPanelControl.PreprocessingPanelVisibleEvent += new EventHandler(PreprocessingPanelControl_PreprocessingPanelVisibleEvent);
        }

        #endregion //Constructor

        #region Event Handlers

        private void PreprocessingPanelControl_PreprocessingPanelVisibleEvent(object sender, EventArgs e)
        {
            preprocessingPanel.Visibility = Visibility.Visible;
            ImageDataBasesExpander.IsExpanded = false;
            ControlPanelExpander.IsExpanded = true;
        }

        private void RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(object sender, RecognizeEventArgs e)
        {
            ImageDataBasesExpander.IsExpanded = false;
            preprocessingPanel.Visibility = Visibility.Hidden;
            ResultsFaceRecMethodsPanel.Visibility = Visibility.Visible;
            ControlPanelExpander.IsExpanded = true;
        }

        private void RecognizeMethodControlBase_RecognizePanelVisibleEvent(object sender, EventArgs e)
        {
            recognizePanel.Visibility = Visibility.Visible;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ResizingWindow.Maximize(Strings.TrainAndTestImagesWindow_Title);
            MainGrid.Height = this.Height;
        }

        private void TrainAndTestFaceViewModel_ControlStateChanged(object sender, ControlReadyEventArgs e)
        {
            if (e.IsReady == true)
                GoPreprocBtn.IsEnabled = true;   
        }

        private void GoPreprocBtn_Click(object sender, RoutedEventArgs e)
        {
            OnDataSaved();
            OnImagesPreprocessed();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion //Event Handlers

        #region Private Methods

        private void OnDataSaved()
        {
            var handler = TrainAndTestDataSavedEvent;

            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        private void OnImagesPreprocessed()
        {
            var handler = ImagesPreprocessedEvent;
            if (handler != null)
            {
                var args = new EventArgs();
                handler(this,args);
            }
        }

        #endregion //Private Methods
    }
}