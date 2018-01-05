using System;
using System.Collections;
using System.Collections.Generic;

namespace FaceRecognition.Model.FaceImagesModel
{
    public class FaceImages : IEnumerable
    {
        #region Fields

        private List<FaceImage> _faceImages;

        #endregion //Fields

        #region Constructors

        public FaceImages()
        {
            _faceImages = new List<FaceImage>();
        }

        public FaceImages(IEnumerable<FaceImage> faceImages):this()
        {
            _faceImages.AddRange(faceImages);
        }

        #endregion //Constructors

        #region Interface Properties

        public FaceImage this[int index]
        {
            get
            {
                try
                {
                    return _faceImages[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("index out of range exception");
                }
            }
        }
        public int Count { get { return _faceImages.Count; } }

        #endregion //Interface Properties

        #region Public Methods

        public void Add(object faceImage)
        {
            var image = faceImage as FaceImage;

            if (image == null)
                throw new NullReferenceException("image");

            _faceImages.Add(image);
        }
        public void AddRange(IEnumerable<FaceImage> faceImages)
        {
            if (faceImages == null)
                throw new ArgumentNullException("faceImages");

            _faceImages.AddRange(faceImages);
        }
        public bool Contains(FaceImage faceImage)
        {
            return _faceImages.Contains(faceImage);
        }
        public void Clear()
        {
            _faceImages.Clear();
        }

        #endregion //Public Methods

        #region Implementation of IEnumerable

        public IEnumerator GetEnumerator()
        {
            return new FaceImagesEnum(_faceImages.ToArray());
        }

        #endregion //Implementation of IEnumerable
    }
}