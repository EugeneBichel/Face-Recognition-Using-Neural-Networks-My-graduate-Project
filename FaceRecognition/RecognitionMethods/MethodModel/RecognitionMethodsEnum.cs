using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.RecognitionMethods.MethodModel
{
    public class RecognitionMethodsEnum:IEnumerator
    {
        #region Fields

        private RecognitionMethodModel[] _recognitionMethods;
        private int _pos;

        #endregion //Fields

        #region Constructor

        public RecognitionMethodsEnum(RecognitionMethodModel[] recognitionMethods)
        {
            _pos = -1;
            _recognitionMethods = recognitionMethods;
        }

        #endregion //Constructor

        #region Implementation of IEnumerator

        public bool MoveNext()
        {
            _pos++;
            return _pos < _recognitionMethods.Length ? true : false;
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
                    return _recognitionMethods[_pos];
                }
                catch (Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex,"Model Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show("Failed get current element");
                }

                return null;
            }
        }

        #endregion //Implementation of IEnumerator
    }
}
