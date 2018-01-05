using System;

namespace FaceRecognition.ViewModel.CustomEventArgs
{
    public class NumberTrainTestFacesEventArgs:EventArgs
    {
        public NumberTrainTestFacesEventArgs(int numberTrainFaces, int numberTestFaces)
        {
            NumberTrainFaces = numberTrainFaces;
            NumberTestFaces = numberTestFaces;
        }

        public int NumberTrainFaces { get; private set; }
        public int NumberTestFaces { get; private set; }
    }
}
