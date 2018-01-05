using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FaceRecognition.RecognitionMethods.MethodModel
{
    public class RecognitionMethodsEnum:IEnumerator
    {
        #region Fields

        private RecognitionMethod[] _recognitionMethods;
        private int _pos;

        #endregion //Fields

        #region Constructor

        public RecognitionMethodsEnum(RecognitionMethod[] recognitionMethods)
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
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range");
                }
            }
        }

        #endregion //Implementation of IEnumerator
    }
}
