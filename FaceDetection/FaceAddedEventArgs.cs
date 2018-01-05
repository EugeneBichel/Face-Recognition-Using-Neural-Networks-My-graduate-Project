using System;
using System.Collections.Generic;
using FaceImagesModel;

namespace FaceDetection
{
    public class FacesAddedEventArgs : EventArgs
    {
        public FacesAddedEventArgs(IEnumerable<FaceImage> faces)
        {
            NewFaces = faces;
        }

        public IEnumerable<FaceImage> NewFaces { get; private set; }
    }
}