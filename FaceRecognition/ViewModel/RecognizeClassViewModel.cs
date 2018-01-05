using System.Collections.ObjectModel;
using FaceImagesModel;

namespace FaceRecognition.ViewModel
{
    public class RecognizeClassViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<FaceImage> _recognizedFaces;
        private bool _isRecognized;
        private FaceImage _testFace;

        #endregion //Fields

        #region Constructors

        public RecognizeClassViewModel()
        {
            _recognizedFaces = new ObservableCollection<FaceImage>();
            _testFace = new FaceImage();
        }

        #endregion //Constructors

        #region Public Properties

        public ObservableCollection<FaceImage> RecognizedFaces
        {
            get { return _recognizedFaces; }
            set
            {
                _recognizedFaces = value;           
                OnPropertyChanged("RecognizedFaces");
            }
        }
        public bool IsRecognized
        {
            get
            {
                return _isRecognized;
            }
            set
            {
                _isRecognized = value;
                OnPropertyChanged("IsRecognized");
            }
        }
        public FaceImage TestFace
        {
            get
            {
                return _testFace;
            }
            set
            {
                _testFace = value;
                OnPropertyChanged("TestFace");
            }
        }

        #endregion //Public Properties
    }
}