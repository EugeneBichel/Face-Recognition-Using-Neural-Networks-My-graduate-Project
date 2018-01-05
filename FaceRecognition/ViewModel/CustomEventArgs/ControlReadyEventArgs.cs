using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    /// <summary>
    /// Event arguments used by TrainAndTestWindow's TrainAndTestReadyEvent
    /// </summary>
    public class ControlReadyEventArgs:EventArgs
    {
        public ControlReadyEventArgs(bool isReady)
        {
            IsReady = isReady;
        }

        public bool IsReady { get; private set; }
    }
}
