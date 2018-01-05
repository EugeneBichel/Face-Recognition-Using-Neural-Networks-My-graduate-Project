namespace FaceRecognition.RecognitionMethods.MethodModel
{
    public class RecognitionMethod
    {
        #region Fields

        private string _name;
        private int _recognitionPercent;
        private int _timeTrain;

        #endregion //Fields

        #region Public Properties

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int RecognitionPercent
        {
            get
            {
                return _recognitionPercent;
            }
            set
            {
                _recognitionPercent = value;
            }
        }
        public int TimeTtrain
        {
            get
            {
                return _timeTrain;
            }
            set
            {
                _timeTrain = value;
            }
        }

        #endregion //Public Properties
    }
}