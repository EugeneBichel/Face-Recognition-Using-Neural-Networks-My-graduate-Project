using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceRecognition.RecognitionMethods
{
    public interface IRecognitionMethod
    {
        bool Train();
        object Recognize(object pattern);
    }
}