using System;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Windows.Forms;

namespace FaceImagesModel
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
                catch (Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex, "Model Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show(string.Format("Failed to get element in {0} position", _pos));
                }

                return null;
            }
        }

        #endregion //Implementation of IEnumerator
    }
}
