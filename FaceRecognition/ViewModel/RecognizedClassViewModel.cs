using System.Collections.ObjectModel;
using FaceImagesModel;

namespace FaceRecognition.ViewModel
{
    public class RecognizedClassViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<FaceImage> _recognizedFaces;
        private FaceImage _testFace;

        #endregion //Fields

        #region Constructors

        public RecognizedClassViewModel()
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