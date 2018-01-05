using System;
using System.Collections;

namespace FaceRecognition.Model.FaceImagesModel
{
    public class FaceDataBasesEnum : IEnumerator
    {
        #region Fields

        private FaceDataBase[] _faceDataBases;
        private int _pos;

        #endregion //Fields

        #region Constructor

        public FaceDataBasesEnum(FaceDataBase[] faceDataBases)
        {
            _pos = -1;
            _faceDataBases = faceDataBases;
        }

        #endregion //Constructor

        #region Implementation of IEnumerator

        public bool MoveNext()
        {
            _pos++;
            return _pos < _faceDataBases.Length ? true : false;
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
                    return _faceDataBases[_pos];
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
