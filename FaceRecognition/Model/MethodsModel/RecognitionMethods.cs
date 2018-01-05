using System;
using System.Collections;
using System.Collections.Generic;

namespace FaceRecognition.RecognitionMethods.MethodModel
{
    public class RecognitionMethods:IEnumerable
    {
        #region Fields

        private List<RecognitionMethod> _recognitionMethods;

        #endregion //Fields

        #region Constructor

        public RecognitionMethods()
        {
            _recognitionMethods = new List<RecognitionMethod>();
        }

        public RecognitionMethods(IEnumerable<RecognitionMethod> recognitionMethods)
            : this()
        {
            _recognitionMethods.AddRange(recognitionMethods);
        }

        #endregion //Constructor

        #region Interface Properties

        public RecognitionMethod this[int index]
        {
            get
            {
                try
                {
                    return _recognitionMethods[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range exception");
                }
            }
        }
        public int Count { get { return _recognitionMethods.Count; } }

        #endregion //Interface Properties

        #region Public Methods

        public void Add(object recognitionMethod)
        {
            var method = recognitionMethod as RecognitionMethod;

            if (method == null)
                throw new NullReferenceException("method");

            _recognitionMethods.Add(method);
        }
        public void AddRange(IEnumerable<RecognitionMethod> recognitionMethods)
        {
            if (recognitionMethods == null)
                throw new ArgumentNullException("recognitionMethods");

            _recognitionMethods.AddRange(recognitionMethods);
        }
        public bool Contains(RecognitionMethod recognitionMethod)
        {
            return _recognitionMethods.Contains(recognitionMethod);
        }
        public void Clear()
        {
            _recognitionMethods.Clear();
        }

        #endregion //Public Methods

        #region IEnumerable Implementation

        public IEnumerator GetEnumerator()
        {
            return new RecognitionMethodsEnum(_recognitionMethods.ToArray());
        }

        #endregion //IEnumerable Implementation
    }
}
