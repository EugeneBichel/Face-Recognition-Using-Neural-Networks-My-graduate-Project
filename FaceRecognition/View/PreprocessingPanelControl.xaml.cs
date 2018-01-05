using System;
using System.Windows.Controls;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    public partial class PreprocessingPanelControl : UserControl
    {
        #region Fields

        private PreprocessingPanelViewModel _preprocessingPanelViewModel;

        #endregion //Fields

        #region Events

        public static event EventHandler PreprocessingPanelVisibleEvent;
        public static event EventHandler FaceImagesSavedEvent;
        public static event EventHandler FacesGotEvent;

        #endregion //Events

        #region Constructors

        public PreprocessingPanelControl()
        {
            _preprocessingPanelViewModel = new PreprocessingPanelViewModel();
            this.DataContext = _preprocessingPanelViewModel;

            InitializeComponent();

            MainWindow.ImagesPreprocessedEvent += new EventHandler(MainWindow_ImagesPreprocessedEvent);
        }

        #endregion //Constructors

        #region Event Handlers

        private void MainWindow_ImagesPreprocessedEvent(object sender, EventArgs e)
        {
            OnFacesGot();
            OnDataSaved();
            OnPreprocessedPanelVisibled();
        }

        #endregion //Event Handlers

        #region Private Methods

        private void OnPreprocessedPanelVisibled()
        {
            var handler = PreprocessingPanelVisibleEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void OnDataSaved()
        {
            var handler = FaceImagesSavedEvent;

            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        private void OnFacesGot()
        {
            var handler = FacesGotEvent;
            if(handler!=null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        #endregion //Private Methods
    }
}
