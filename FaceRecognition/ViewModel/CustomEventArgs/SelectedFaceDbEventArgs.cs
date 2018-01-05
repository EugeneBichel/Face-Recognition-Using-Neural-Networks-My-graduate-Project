using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    public class SelectedFaceDbEventArgs:EventArgs
    {
        public SelectedFaceDbEventArgs(int selectedId)
        {
            SelectedId = selectedId;
        }

        public int SelectedId { get; private set; }
    }
}
