using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    public class TrainSuccessEventArgs:EventArgs
    {
        public TrainSuccessEventArgs(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; private set; }
    }
}
