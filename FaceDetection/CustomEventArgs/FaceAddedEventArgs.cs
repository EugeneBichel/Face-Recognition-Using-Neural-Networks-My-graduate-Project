using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceImagesModel;

namespace FaceDetection.CustomEventArgs
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