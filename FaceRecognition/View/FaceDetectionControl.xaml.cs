using System.Collections.ObjectModel;
using System.Windows.Controls;
using FaceDetection;
using FaceRecognition.Model.FaceImagesModel;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    public partial class FaceDetectionControl : UserControl
    {
        #region Fields

        private FaceDetectionViewModel _faceDetectionViewModel;
        private FdFaceDetection _faceDetectionRepository;
        private bool _isTestImageSelected;
        private ObservableCollection<FaceImage> _trainImages;
        private ObservableCollection<FaceImage> _testImages;

        #endregion //Fields

        #region Constructor

        public FaceDetectionControl()
        {
            _trainImages = new ObservableCollection<FaceImage>();
            _testImages = new ObservableCollection<FaceImage>();
            _faceDetectionRepository = new FdFaceDetection();
            _faceDetectionViewModel = new FaceDetectionViewModel();

            this.DataContext = _faceDetectionViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Public Properties

        public ObservableCollection<FaceImage> TrainImages 
        { 
            get
            {
                return _trainImages;
            }
            set
            {
                _trainImages = value;
                _faceDetectionViewModel.TrainFaces = _trainImages;
                _faceDetectionViewModel.OnPropertyChanged("TrainFaces");
            }
        }
        public ObservableCollection<FaceImage> TestImages
        {
            get
            {
                return _testImages;
            }
            set
            {
                _testImages = value;
                _faceDetectionViewModel.TestFaces = TestImages;
                _faceDetectionViewModel.OnPropertyChanged("TestFaces");
            }
        }

        #endregion //Public Proerties
    }
}
