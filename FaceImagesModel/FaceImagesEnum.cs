using System;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Windows.Forms;

namespace FaceImagesModel
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
                catch (Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex, "Model Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show(string.Format("Failed to get element by {0} position", _pos));
                }
                return null;
            }
        }

        #endregion //Implementation of IEnumerator
    }
}