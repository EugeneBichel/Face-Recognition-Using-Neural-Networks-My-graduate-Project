using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FaceImagesModel;
using FaceImagesModel.Properties;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using OpenCvSharp;
using Utility;

namespace FaceDetection
{
    public class FdFaceDetection
    {
        //const double Scale = 1.14;
        //const double ScaleFactor = 1.0850;
        //const int MinNeighbors = 2;

        #region Fields

        private double _scale;
        private double _scaleFactor;
        private int _minNeighbors;
        private Bitmap _face;
        private long _detectionTime; //ms

        #endregion //Fields

        #region Events

        /// <summary>
        /// Raised when a faces are placed  into the repository for faces
        /// </summary>
        public static event EventHandler<FacesAddedEventArgs> FacesAdded;
        public static event EventHandler<FacesAddedEventArgs> TrainFacesAdded;
        public static event EventHandler<FacesAddedEventArgs> TestFacesAdded;

        #endregion //Events

        #region Constructor
        
        public FdFaceDetection()
        {
            _scale =  1.14;
            _scaleFactor = 2;// 1.0850;
            _minNeighbors = 2;
            _face = null;
        }
        
        #endregion //Constructor

        #region Public Properties

        public double Scale
        { 
            get { return _scale; }
            set
            {
                if (_scale != value)
                {
                    _scale = value;
                    //FaceDetect();
                }
            }
        }
        public Bitmap Face
        {
            get { return _face; }
            private set { _face = value; }
        }
        public double ScaleFactor
        {
            get { return _scaleFactor; }
        }
        public int MinNeighbors
        {
            get { return _minNeighbors; }
        }
        public long DetectionTime
        {
            get { return _detectionTime; }
            private set { _detectionTime = value; }
        }

        #endregion //Public Properties

        #region Public Methods

        /// <summary>
        /// Separate face from image
        /// </summary>
        public IEnumerable<FaceImage> SeparateFaces(IEnumerable<FaceImage> faceImages, TrainTestFacesEnum trainTestEnum)
        {
            var faces = new List<FaceImage>();
            //var defScale = Scale;

            foreach (FaceImage faceImage in faceImages)
            {
                bool isTrue = false;
                FaceImage newImage = null;

                try
                {

                    newImage = FaceDetect(faceImage);
                }
                catch(Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogic Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show("Failed to separate face from {0} image", faceImage.FullName);
                }
                if (newImage != null)
                    faces.Add(newImage);
            }

            OnFaceAdded(faces);

            //if (trainTestEnum == TrainTestFacesEnum.TestFaces)
            //{
            //    OnTestFacesAdded(faces);
            //}
            //else if (trainTestEnum == TrainTestFacesEnum.TrainFaces)
            //{
            //    OnTrainFacesAdded(faces);
            //}

            return faces;
        }

        #endregion //Public Methods

        #region Face Detection

        private FaceImage FaceDetect(FaceImage faceImage)
        {
            if (faceImage.FullName == null || File.Exists(faceImage.FullName) == false || faceImage.FullName == string.Empty)
                throw new ArgumentException("Image's path is not valid: {0}.", faceImage.FullName);

            var facesDir = CreateDirByShortName(Strings.Face_Database_Folder_Name);

            var fullName = CreateFaceFileFullName(faceImage, facesDir);

            faceImage.FullName = fullName;

            if (File.Exists(fullName))
                return faceImage;

            try
            {

                using (IplImage img = new IplImage(faceImage.FullName, LoadMode.AnyColor))
                {
                    using (IplImage smallImg = new IplImage(new CvSize(Cv.Round(img.Width / Scale), Cv.Round(img.Height / Scale)), BitDepth.U8, 1))
                    {
                        using (IplImage gray = new IplImage(img.Size, BitDepth.U8, 1))
                        {
                            Cv.CvtColor(img, gray, ColorConversion.BgrToGray);
                            Cv.Resize(gray, smallImg, Interpolation.Linear);
                            Cv.EqualizeHist(smallImg, smallImg);
                        }

                        //using (CvHaarClassifierCascade cascade = Cv.Load<CvHaarClassifierCascade>(Const.XmlHaarcascade))
                        using (CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile(Constants.FaceCascadeDefFileName))
                        using (CvMemStorage storage = new CvMemStorage())
                        {
                            storage.Clear();

                            Stopwatch watch = Stopwatch.StartNew();
                            CvSeq<CvAvgComp> faces = Cv.HaarDetectObjects(smallImg, cascade, storage,/*1.2*/ ScaleFactor, MinNeighbors, 0, new CvSize(30, 30));//(30,30)
                            watch.Stop();

                            DetectionTime = watch.ElapsedMilliseconds; //detection time (ms)

                            for (int i = 0; i < faces.Total; i++)
                            {
                                CvRect r = faces[i].Value.Rect;
                                //CvPoint center = new CvPoint
                                //{
                                //    X = Cv.Round((r.X + r.Width * 0.5) * Scale),
                                //    Y = Cv.Round((r.Y + r.Height * 0.5) * Scale)
                                //};
                                //int radius = Cv.Round((r.Width + r.Height) * 0.25 * Scale);
                                //img.Circle(center, radius, new CvColor(0, 0, 255), 3, LineType.AntiAlias, 0);

                                smallImg.ROI = new CvRect(r.X, r.Y, r.Width, r.Height);

                                IplImage subImage = smallImg.GetSubImage(smallImg.ROI);

                                _face = BitmapConverter.ToBitmap(subImage);

                                FaceImage newFaceImage = SaveFace(faceImage);
                                return newFaceImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogin Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed to separate face from image"));
            }
            return null;
        }

        #endregion //Face Detection

        #region SaveFace

        private FaceImage SaveFace(FaceImage faceImage)
        {
            var facesDir = CreateDirByShortName(Strings.Face_Database_Folder_Name);
            var fullName = CreateFaceFileFullName(faceImage, facesDir);

            FaceImage face = SaveToFile(faceImage, fullName);

            return face;
        }
        private string CreateDirByShortName(string name)
        {
            var facesDir = string.Empty;

            try
            {
                facesDir = Path.Combine(Helper.GetExecutedDirectory(), name);
                if (Directory.Exists(facesDir) == false)
                    Directory.CreateDirectory(facesDir);

                return facesDir;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed to create {0} directory", facesDir));
            }

            return null;
        }
        private void CreateDirByFullName(string path)
        {
            try
            {
                if (Directory.Exists(path) == false)
                    Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed to create {0} directory", path));
            }
        }
        private FaceImage SaveToFile(FaceImage savedFace, string fullName)
        {
            try
            {
                savedFace.FullName = fullName;
                if (File.Exists(fullName) == false)
                    _face.Save(savedFace.FullName);

                return savedFace;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed to save {0} file", savedFace.FullName));
            }

            return null;
        }
        private string CreateFaceFileFullName(FaceImage faceImage, string facesDir)
        {
            string[] parts = faceImage.FullName.Split('\\');
            for (var i = 0; i < parts.Length; i++)
            {
                if (parts[i].Equals(Strings.Images_Database_Folder_Name))
                    parts[i] = Strings.Face_Database_Folder_Name;

                if (i != parts.Length - 1)
                {
                    var path = GetPath(parts, i + 1);
                    CreateDirByFullName(path);
                }
            }

            return GetPath(parts);
        }
        private string GetPath(string[] parts)
        {
            var index = 0;
            var sbNewPath = new StringBuilder();

            foreach (var part in parts)
            {
                if (index != 0)
                    sbNewPath.Append("\\");

                sbNewPath.Append(part);
                index++;
            }

            return sbNewPath.ToString();
        }
        private string GetPath(string[] parts, int numParts)
        {
            var index = 0;
            var sbNewPath = new StringBuilder();

            for (var i = 0; i < numParts; i++)
            {
                if (index != 0)
                    sbNewPath.Append("\\");

                sbNewPath.Append(parts[i]);
                index++;
            }

            return sbNewPath.ToString();
        }

        #endregion //FaceSave

        #region OnFacesAdded

        private void OnFaceAdded(IEnumerable<FaceImage> faces)
        {
            var handler = FacesAdded;
            if (handler != null)
            {
                var e = new FacesAddedEventArgs(faces);
                handler(this, e);
            }
        }
        private void OnTrainFacesAdded(IEnumerable<FaceImage> faces)
        {
            var handler = TrainFacesAdded;
            if (handler != null)
            {
                var e = new FacesAddedEventArgs(faces);
                handler(this, e);
            }
        }
        private void OnTestFacesAdded(IEnumerable<FaceImage> faces)
        {
            var handler = TestFacesAdded;
            if (handler != null)
            {
                var e = new FacesAddedEventArgs(faces);
                handler(this, e);
            }
        }

        #endregion //OnFacesAdded
    }
}