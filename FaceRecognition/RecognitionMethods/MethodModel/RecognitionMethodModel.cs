using System;
namespace FaceRecognition.RecognitionMethods.MethodModel
{
    public class RecognitionMethodModel
    {
        #region Fields

        private string _name;
        private double _recognitionPercent;
        private double _timeRec;

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
        public double RecognitionPercent
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
        public double TimeRecognize
        {
            get
            {
                return _timeRec;
            }
            set
            {
                _timeRec = value;
            }
        }

        #endregion //Public Properties
    }
}