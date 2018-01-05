using System;
using System.Collections;
using System.Collections.Generic;

namespace FaceRecognition.Model.FaceImagesModel
{
    public class FaceDataBases : IEnumerable
    {
        #region Fields

        private List<FaceDataBase> _faceDataBases;

        #endregion //Fields

        #region Constructors

        public FaceDataBases()
        {
            _faceDataBases = new List<FaceDataBase>();
        }

        public FaceDataBases(IEnumerable<FaceDataBase> faceDataBases):this()
        {
            _faceDataBases.AddRange(faceDataBases);
        }

        #endregion //Constructors

        #region Interface Properties

        public FaceDataBase this[int index]
        {
            get
            {
                try
                {
                    return _faceDataBases[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range exception");
                }
            }
        }
        public FaceDataBase this[string shortNameDb]
        {
            get
            {
                try
                {
                    return GetFaceFbByShortName(shortNameDb);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range exception");
                }
            }
        }
        public int Count { get { return _faceDataBases.Count; } }

        #endregion //Interface Properties

        #region Public Methods

        public void Add(FaceDataBase faceDataBase)
        {
            if (faceDataBase == null)
                throw new ArgumentNullException("faceDataBase");

            _faceDataBases.Add(faceDataBase);
        }

        #endregion //Public Methods

        #region Implementation of IEnumerable

        public IEnumerator GetEnumerator()
        {
            return new FaceDataBasesEnum(_faceDataBases.ToArray());
        }

        #endregion //Implementation of IEnumerable

        #region Helper Methods

        private FaceDataBase GetFaceFbByShortName(string shortName)
        {
            foreach (FaceDataBase db in _faceDataBases)
            {
                if (db.ShortName.Equals(shortName))
                    return db;
            }
            return null;
        }

        #endregion //Helper Methods
    }
}
