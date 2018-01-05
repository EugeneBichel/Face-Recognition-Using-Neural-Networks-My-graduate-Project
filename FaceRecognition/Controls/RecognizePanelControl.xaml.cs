using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FaceImagesModel;
using FaceRecognition.ViewModel;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using System;

namespace FaceRecognition.Controls
{
    public partial class RecognizePanelControl : UserControl
    {
        #region Fields

        private RecognizePanelViewModel _recognizePanelViewModel;
        private string _selectedMethod;

        #endregion //Fields
        
        #region Constructors

        public RecognizePanelControl()
        {
            InitializeComponent();
            _recognizePanelViewModel = new RecognizePanelViewModel();
            RecognizeMethodsViewModelBase.DrawRecongitionResultsEvent += new EventHandler<RecognizeEventArgs>(RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent);
            SelectionRecognitionMethodControl.ClearRecognizedFacesPanelEvent += new EventHandler(SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEvent);
        }

        public RecognizePanelControl(RecognizePanelViewModel recognizePanelViewModel)
        {
            InitializeComponent();
            _recognizePanelViewModel = recognizePanelViewModel;
            RecognizeMethodsViewModelBase.DrawRecongitionResultsEvent += new EventHandler<RecognizeEventArgs>(RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent);
            SelectionRecognitionMethodControl.ClearRecognizedFacesPanelEvent += new EventHandler(SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEvent);
        }

        #endregion //Constructors

        #region Event Handlers

        private void RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(object sender, RecognizeEventArgs e)
        {
            _selectedMethod = e.MethodName;
            _recognizePanelViewModel.LoadTrainTestRecognizedFaces();
            FillPanel();
        }

        private void SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEvent(object sender, System.EventArgs e)
        {
            Content = null;
        }

        #endregion //Event Handlers

        #region Private Methods

        private void FillPanel()
        {
            var scroll = new ScrollViewer();
            Content = scroll;
            scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            var mainGroupBox = new GroupBox();
            mainGroupBox.Header = _selectedMethod;
            scroll.Content = mainGroupBox;
            var recognitionStackPanel = new StackPanel();
            recognitionStackPanel.Margin = new Thickness(5);
            mainGroupBox.Content = recognitionStackPanel;

            for (var i = 0; i < _recognizePanelViewModel.TestFaces.Count; i++)
            {
                var recognizedClassControl = new RecognizeClassControl();
                recognizedClassControl.RecognizedClassViewModel.TestFace = _recognizePanelViewModel.TestFaces[i];
                foreach(FaceImage face in _recognizePanelViewModel.RecognizedFaces)
                {
                    if (face.PersonId.Equals(_recognizePanelViewModel.TestFaces[i].PersonId))
                        recognizedClassControl.RecognizedClassViewModel.RecognizedFaces.Add(face);
                }
                if (recognizedClassControl.RecognizedClassViewModel.RecognizedFaces.Count == 0)
                    recognizedClassControl.RecognizedClassViewModel.IsRecognized = false;
                else
                    recognizedClassControl.RecognizedClassViewModel.IsRecognized = true;

                recognizedClassControl.HorizontalAlignment = HorizontalAlignment.Stretch;

                var groupBox = new GroupBox();
                groupBox.Content = recognizedClassControl;
                groupBox.Header = "Test Face: " + (i + 1).ToString();

                var border = new Border();
                border.Child = groupBox;
                border.Margin = new Thickness(5);
                border.BorderBrush = Brushes.DarkGray;
                border.BorderThickness = new Thickness(2);

                recognitionStackPanel.Children.Add(border);
            }
        }

        #endregion //Private Methods
    }
}
