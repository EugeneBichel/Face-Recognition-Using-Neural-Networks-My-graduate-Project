using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using FaceImagesModel.Properties;
using Utility;

namespace FaceImagesModel
{
    public class FaceImage : IDataErrorInfo
    {
        #region Constructors

        //for serialization objects
        public FaceImage()
        {

        }

        public FaceImage(string shortName, string fullName, string persongId, string shortNameDb)
        {
            if (Helper.IsStringMissing(shortName))
                throw new ArgumentException("shortName");
            if (Helper.IsStringMissing(fullName))
                throw new ArgumentException("fullName");
            if (Helper.IsStringMissing(persongId))
                throw new ArgumentException("persongId");
            if (Helper.IsStringMissing(shortNameDb))
                throw new ArgumentException("shortNameDb");

            ShortName = shortName;
            FullName = fullName;
            PersonId = persongId;
            ShortNameDb = shortNameDb;
            Information = "Name: " + ShortName + "\n" + "PersonId: " + PersonId;
        }

        public FaceImage(string shortName, string fullName, string persongId, string shortNameDb, double[] vectorBeforeFft)
        {
            if (Helper.IsStringMissing(shortName))
                throw new ArgumentException("shortName");
            if (Helper.IsStringMissing(fullName))
                throw new ArgumentException("fullName");
            if (Helper.IsStringMissing(persongId))
                throw new ArgumentException("persongId");
            if (Helper.IsStringMissing(shortNameDb))
                throw new ArgumentException("shortNameDb");
            if (vectorBeforeFft == null)
                throw new ArgumentNullException("vectorBeforeFft");

            ShortName = shortName;
            FullName = fullName;
            PersonId = persongId;
            ShortNameDb = shortNameDb;
            VectorBeforeFft = vectorBeforeFft;
            Information = "Name: " + ShortName + "\n" + "PersonId: " + PersonId;
        }

        public FaceImage(string shortName, string fullName, string persongId, string shortNameDb, double[] vectorBeforeFft, double[] vectorAfterFft)
        {
            if (Helper.IsStringMissing(shortName))
                throw new ArgumentException("shortName");
            if (Helper.IsStringMissing(fullName))
                throw new ArgumentException("fullName");
            if (Helper.IsStringMissing(persongId))
                throw new ArgumentException("persongId");
            if (Helper.IsStringMissing(shortNameDb))
                throw new ArgumentException("shortNameDb");
            if (vectorBeforeFft==null)
                throw new ArgumentNullException("vectorBeforeFft");
            if (vectorAfterFft == null)
                throw new ArgumentNullException("vectorAfterFft");

            ShortName = shortName;
            FullName = fullName;
            PersonId = persongId;
            ShortNameDb = shortNameDb;
            VectorBeforeFft = vectorBeforeFft;
            VectorAfterFft = vectorAfterFft;
            Information = "Name: " + ShortName + "\n" + "PersonId: " + PersonId;
        }

        #endregion //Constructors

        #region State Properties

        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string PersonId { get; set; }
        public string Information { get; set; }
        public string ShortNameDb { get; set; }
        public double[] VectorBeforeFft { get; set; }
        public double[] VectorAfterFft { get; set; }
        public double[] VectorInNet { get; set; }

        #endregion //State Properties

        #region Implementation of IDataErrorInfo

        public string this[string propertyName]
        {
            get { return GetValidationError(propertyName); }
        }

        public string Error
        {
            get { return null; }
        }

        #endregion

        #region Valudation

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
                                                                   "FullName", 
                                                                   "ShortName",
                                                                   "PersonId",
                                                                   "Information",
                                                                   "ShortNameDb",
                                                                   "VectorBeforeFft",
                                                                   "VectorAfterFft",
                                                                   "VectorInNet"
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

                case "PersonId":
                    error = ValidatePersonId();
                    break;

                case "Information":
                    error = ValidateInformation();
                    break;

                case "ShortNameDb":
                    error = ValidateShortNameDb();
                    break;

                case "VectorBeforeFFT":
                    error = ValidateVectorBeforeFFT();
                    break;

                case "VectorAfterFFT":
                    error = ValidateVectorAfterFFT();
                    break;

                case "VectorInNet":
                    error = ValidateVectorInNet();
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
                return Strings.Face_Image_Error_MissingFullName;
            return null;
        }

        private string ValidateFullName()
        {
            if (Helper.IsStringMissing(FullName))
                return Strings.Face_Image_Error_MissingShortNameFaceImages;
            return null;
        }

        private string ValidatePersonId()
        {
            if (Helper.IsStringMissing(PersonId))
                return Strings.Face_Image_Error_MissingPersonId;
            return null;
        }

        private string ValidateInformation()
        {
            if (Helper.IsStringMissing(Information))
                return Strings.Face_Image_Error_MissingInformation;
            return null;
        }

        private string ValidateShortNameDb()
        {
            if (Helper.IsStringMissing(Information))
                return Strings.Face_Image_Error_MissingDataBase;
            return null;
        }

        private string ValidateVectorBeforeFFT()
        {
            //TODO:
            return null;
        }

        private string ValidateVectorAfterFFT()
        {
            //TODO:
            return null;
        }

        private string ValidateVectorInNet()
        {
            return null;
        }

        #endregion //Validation
    }
}