using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using FaceImagesModel.Properties;
using Utility;

namespace FaceImagesModel
{
    public class FaceDataBase : IDataErrorInfo
    {
        private FaceImages _faceImages;

        #region Constructor

        public FaceDataBase()
        {
            _faceImages = new FaceImages();
        }

        public FaceDataBase(IEnumerable<FaceImage> faceImages)
        {
            _faceImages = new FaceImages(faceImages);
        }

        #endregion //Constructor

        #region Interface Properties

        public string FullName { get; set; }
        public string ShortName { get; set; }
        public FaceImages FaceImages
        {
            get { return _faceImages; }
        }

        #endregion //Interface Properties

        #region Public Methods

        public void Add(IEnumerable<FaceImage> faceImages)
        {
            _faceImages.AddRange(faceImages);
        }
        public void Add(FaceImages faceImages)
        {
            _faceImages = faceImages;
        }

        #endregion //Public Methods

        #region Implementation of IDataErrorInfo

        public string this[string propertyName]
        {
            get { return GetValidationError(propertyName); }
        }

        public string Error
        {
            get { return null; }
        }

        #endregion //Implementation of IDataErrorInfo

        #region Validation

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return ValidatedProperties.All(property => GetValidationError(property) == null);
            }
        }

        private static readonly string[] ValidatedProperties = {
                                                                   "FullName", "ShortName"
                                                               };

        private string GetValidationError(string propertyName)
        {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName)
            {
                case "FullName":
                    error = ValidateFullName();
                    break;

                case "ShortName":
                    error = ValidateShortName();
                    break;

                default:
                    Debug.Fail("Unexpected property being validated on FaceImage: " + propertyName);
                    break;
            }

            return error;
        }

        private string ValidateShortName()
        {
            if (Helper.IsStringMissing(ShortName))
                return Strings.Face_DataBase_Error_MissingShortName;
            return null;
        }

        private string ValidateFullName()
        {
            if (Helper.IsStringMissing(FullName))
                return Strings.Face_DataBase_Error_MissingFullName;
            return null;
        }

        #endregion //Validation
    }
}