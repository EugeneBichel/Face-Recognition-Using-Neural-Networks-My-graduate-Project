using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.Properties;
using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Utility;

namespace FaceRecognition.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        #region Fields

        protected List<string> _imageClasses;
        protected ObservableCollection<FaceImage> _images;
        protected ObservableCollection<FaceImage> _trainFaces;
        protected ObservableCollection<FaceImage> _testFaces;
        protected ObservableCollection<FaceImage> _trainImages;
        protected ObservableCollection<FaceImage> _testImages;
        protected ObservableCollection<FaceImage> _recognizedFaces;

        private static int numTrainTestImagesPropertiesReady;
        private static int numTrainTestFacesPropertiesReady;

        #endregion //Fields

        #region Events

        public static event EventHandler<ControlReadyEventArgs> ControlStateChanged;

        #endregion //Events

        #region Constructor

        protected ViewModelBase()
        {
        }

        static ViewModelBase()
        {
            numTrainTestImagesPropertiesReady = 0;
            numTrainTestFacesPropertiesReady = 0;
        }

        #endregion // Constructor

        #region Public Properties

        public ObservableCollection<FaceImage> Images
        {
            get { return _images; }
            set
            {
                _images = value;
                OnPropertyChanged("Images");
            }
        }
        public ObservableCollection<FaceImage> TrainFaces
        {
            get { return _trainFaces; }
            set
            {
                _trainFaces = value;
                OnPropertyChanged("TrainFaces");
            }
        }
        public ObservableCollection<FaceImage> TestFaces
        {
            get { return _testFaces; }
            set
            {
                _testFaces = value;
                OnPropertyChanged("TestFaces");
            }
        }
        public ObservableCollection<FaceImage> TrainImages
        {
            get
            {
                return _trainImages;
            }
            set
            {
                _trainImages = value;
                OnPropertyChanged("TrainImages");
            }
        }
        public ObservableCollection<FaceImage> TestImages
        {
            get { return _testImages; }
            set
            {
                _testImages = value;
                OnPropertyChanged("TestImages");
            }
        }
        public ObservableCollection<FaceImage> RecognizedFaces
        {
            get
            {
                return _recognizedFaces;
            }
            set
            {
                _recognizedFaces = value;
                OnPropertyChanged("RecognizedFaces");
            }
        }

        #endregion //Public Properties

        #region Save/Loaded Data

        protected void SaveTrainImages()
        {
            SaveData(Strings.FileName_TrainImages,ref _trainImages);
        }
        protected void SaveTestImages()
        {
            SaveData(Strings.FileName_TestImages, ref _testImages);
        }

        protected void SaveTrainFaces()
        {
            SaveData(Strings.FileName_TrainFaces, ref _trainFaces);
        }
        protected void SaveTestFaces()
        {
            SaveData(Strings.FileName_TestFaces, ref _testFaces);
        }

        protected void LoadTrainImages()
        {
            LoadData(Strings.FileName_TrainImages, out _trainImages);
        }
        protected void LoadTestImages()
        {
            LoadData(Strings.FileName_TestImages, out _testImages);
        }

        protected void LoadTrainFaces()
        {
            LoadData(Strings.FileName_TrainFaces, out _trainFaces);
        }
        protected void LoadTestFaces()
        {
            LoadData(Strings.FileName_TestFaces, out _testFaces);
        }

        protected void LoadRecognizedFaces()
        {
            LoadData(Strings.FileName_RecognizedFaces, out _recognizedFaces);
        }
        protected void SaveRecognizedFaces()
        {
            SaveData(Strings.FileName_RecognizedFaces, ref _recognizedFaces);
        }

        protected string CreateDataDir(string shortFileName)
        {
            try
            {
                var dataDir = Path.Combine(Helper.GetExecutedDirectory(), shortFileName.Split('\\')[0]);
                if (Directory.Exists(dataDir) == false)
                    Directory.CreateDirectory(dataDir);
                return dataDir;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;
                MessageBox.Show("failed create directory");
            }
            return null;
        }

        #endregion //Save/Loaded Data

        #region DisplayName

        /// <summary>
        /// Returns the user-friendly name of this object.
        /// Child classes can set this property to a new value,
        /// or override it to determine the value on-demand.
        /// </summary>
        public virtual string DisplayName { get; protected set; }

        #endregion // DisplayName

        #region Debugging Aides

        /// <summary>
        /// Warns the developer if this object does not have
        /// a public property with the specified name. This 
        /// method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,  
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;

                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        /// <summary>
        /// Returns whether an exception is thrown, or if a Debug.Fail() is used
        /// when an invalid property name is passed to the VerifyPropertyName method.
        /// The default value is false, but subclasses used by unit tests might 
        /// override this property's getter to return true.
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        #endregion // Debugging Aides

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises this object's PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The property that has a new value.</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);

            if (Constants.TrainAndTestViewProperties.Contains(propertyName))
            {
                numTrainTestImagesPropertiesReady++;
                if (numTrainTestImagesPropertiesReady == Constants.TrainAndTestViewProperties.Count)
                {
                    numTrainTestImagesPropertiesReady = 0;

                    EventHandler<ControlReadyEventArgs> handler = ControlStateChanged;
                    if (handler != null)
                    {
                        var arg = new ControlReadyEventArgs(true);
                        handler(this, arg);
                    }
                }
            }

            else if (Constants.RecognitionMethodsViewProperties.Contains(propertyName))
            {
                EventHandler<ControlReadyEventArgs> handler = ControlStateChanged;
                if (handler != null)
                {
                    var arg = new ControlReadyEventArgs(true);
                    handler(this, arg);
                }
            }

            PropertyChangedEventHandler propertyChangedHandler = this.PropertyChanged;
            if (propertyChangedHandler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                propertyChangedHandler(this, e);
            }
        }

        #endregion //INotifyPropertyChanged Members

        #region IDisposable Members

        /// <summary>
        /// Invoked when this object is being removed from the application
        /// and will be subject to garbage collection.
        /// </summary>
        public void Dispose()
        {
            this.OnDispose();
        }

        /// <summary>
        /// Child classes can override this method to perform 
        /// clean-up logic, such as removing event handlers.
        /// </summary>
        protected virtual void OnDispose()
        {
        }

#if DEBUG
        /// <summary>
        /// Useful for ensuring that ViewModel objects are properly garbage collected.
        /// </summary>
        ~ViewModelBase()
        {
            string msg = string.Format("{0} ({1}) ({2}) Finalized", this.GetType().Name, this.DisplayName, this.GetHashCode());
            System.Diagnostics.Debug.WriteLine(msg);
        }
#endif

        #endregion //IDisposable Members

        #region Helper Methods

        private void SaveData(string shortFileName, ref ObservableCollection<FaceImage> images)
        {
            CreateDataDir(shortFileName);

            var path = Path.Combine(Helper.GetExecutedDirectory(), shortFileName);

            try
            {
                Helper.SerializeObject(typeof(ObservableCollection<FaceImage>), images, path);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed to save data");
            }
        }
        private void LoadData(string shortFileName, out ObservableCollection<FaceImage> images)
        {
            CreateDataDir(shortFileName);
            images = new ObservableCollection<FaceImage>();
            try
            {
                var path = Path.Combine(Helper.GetExecutedDirectory(), shortFileName);

                images = Helper.DeserializeObject(typeof(ObservableCollection<FaceImage>), path) as ObservableCollection<FaceImage>;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;
                MessageBox.Show("Failed load data from data base");
            }
        }

        #endregion //Helper Methods
    }
}