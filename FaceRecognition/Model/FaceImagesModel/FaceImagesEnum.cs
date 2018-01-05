using System;
using System.Collections;

namespace FaceRecognition.Model.FaceImagesModel
{
    public class FaceImagesEnum : IEnumerator
    {
        #region Fields

        private FaceImage[] _faceImages;
        private int _pos;

        #endregion //Fields

        #region Constructor

        public FaceImagesEnum(FaceImage[] faceImages)
        {
            _pos = -1;
            _faceImages = faceImages;
        }

        #endregion //Constructor

        #region Implementation of IEnumerator

        public bool MoveNext()
        {
            _pos++;
            return _pos < _faceImages.Length ? true : false;
        }

        public void Reset()
        {
            _pos = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return _faceImages[_pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range");
                }
            }
        }

        #endregion //Implementation of IEnumerator
    }
}