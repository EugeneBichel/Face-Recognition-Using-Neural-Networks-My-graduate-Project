using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    public class RecognizeMethodEventArgs:EventArgs
    {
        public RecognizeMethodEventArgs(string selectedMethod)
        {
            SelectedMethod = selectedMethod;
        }

        public string SelectedMethod { get; private set; }
    }
}