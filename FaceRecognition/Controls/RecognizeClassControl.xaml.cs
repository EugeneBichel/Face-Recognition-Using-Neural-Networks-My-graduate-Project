using System.Windows.Controls;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    public partial class RecognizeClassControl : UserControl
    {
        #region Fields

        private RecognizeClassViewModel _recognizedClassViewModel;

        #endregion //Fields

        #region Constructor

        public RecognizeClassControl()
        {
            _recognizedClassViewModel = new RecognizeClassViewModel();
            this.DataContext = _recognizedClassViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Public Properties

        public RecognizeClassViewModel RecognizedClassViewModel
        {
            get { return _recognizedClassViewModel; }
        }

        #endregion //Public Properties
    }
}
