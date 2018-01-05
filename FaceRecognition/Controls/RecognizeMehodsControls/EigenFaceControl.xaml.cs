using System.Windows;
using FaceRecognition.ViewModel.RecognitionMethodsViewModel;

namespace FaceRecognition.Controls.RecognizeMehodsControls
{
    public partial class EigenFaceControl : RecognizeMethodControlBase
    {
        #region Fields

        private EigenFaceViewModel _eigenFaceViewModel;

        #endregion //Fields

        #region Constructor

        public EigenFaceControl()
        {
            _eigenFaceViewModel = new EigenFaceViewModel();
            this.DataContext = _eigenFaceViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Handlers

        private void reproduceButton_Click(object sender, RoutedEventArgs e)
        {
            OnRecognizePanelVisible();
            _eigenFaceViewModel.Recognize();
        }

        private void trainButton_Click(object sender, RoutedEventArgs e)
        {
            OnSavedData();
            _eigenFaceViewModel.Train();
        }

        #endregion //Handlers
    }
}
