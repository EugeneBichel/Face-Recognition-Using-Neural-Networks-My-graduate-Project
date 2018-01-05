using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    public class RecognizeEventArgs:EventArgs
    {
        public RecognizeEventArgs(string methodName, double timeValue, double percentRecFaces)
        {
            MethodName = methodName;
            PercentRecFaces = percentRecFaces;
            RecognizeTime = timeValue;
        }

        public string MethodName { get; private set; }
        public double PercentRecFaces { get; private set; }
        public double RecognizeTime { get; private set; }
    }
}
