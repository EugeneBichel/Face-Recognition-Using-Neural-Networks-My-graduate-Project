using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceImagesModel;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for ViewModelBaseTest and is intended
    ///to contain all ViewModelBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ViewModelBaseTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual ViewModelBase_Accessor CreateViewModelBase_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            ViewModelBase_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for CreateDataDir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void CreateDataDirTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            string shortFileName = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CreateDataDir(shortFileName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual ViewModelBase CreateViewModelBase()
        {
            // TODO: Instantiate an appropriate concrete class.
            ViewModelBase target = null;
            return target;
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Finalize
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void FinalizeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Finalize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadData
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadDataTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            string shortFileName = string.Empty; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> images = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> imagesExpected = null; // TODO: Initialize to an appropriate value
            target.LoadData(shortFileName, out images);
            Assert.AreEqual(imagesExpected, images);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadRecognizedFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadRecognizedFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.LoadRecognizedFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadTestFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadTestFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.LoadTestFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadTestImages
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadTestImagesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.LoadTestImages();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadTrainFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadTrainFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.LoadTrainFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadTrainImages
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadTrainImagesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.LoadTrainImages();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnDispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnDisposeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.OnDispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnPropertyChanged
        ///</summary>
        [TestMethod()]
        public void OnPropertyChangedTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            target.OnPropertyChanged(propertyName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveData
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveDataTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            string shortFileName = string.Empty; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> images = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> imagesExpected = null; // TODO: Initialize to an appropriate value
            target.SaveData(shortFileName, ref images);
            Assert.AreEqual(imagesExpected, images);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveRecognizedFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveRecognizedFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SaveRecognizedFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveTestFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveTestFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SaveTestFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveTestImages
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveTestImagesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SaveTestImages();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveTrainFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveTrainFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SaveTrainFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveTrainImages
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveTrainImagesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SaveTrainImages();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for VerifyPropertyName
        ///</summary>
        [TestMethod()]
        public void VerifyPropertyNameTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            target.VerifyPropertyName(propertyName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void DisplayNameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.DisplayName = expected;
            actual = target.DisplayName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Images
        ///</summary>
        [TestMethod()]
        public void ImagesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.Images = expected;
            actual = target.Images;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognizedFaces
        ///</summary>
        [TestMethod()]
        public void RecognizedFacesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.RecognizedFaces = expected;
            actual = target.RecognizedFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TestFaces
        ///</summary>
        [TestMethod()]
        public void TestFacesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.TestFaces = expected;
            actual = target.TestFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TestImages
        ///</summary>
        [TestMethod()]
        public void TestImagesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.TestImages = expected;
            actual = target.TestImages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ThrowOnInvalidPropertyName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ThrowOnInvalidPropertyNameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ViewModelBase_Accessor target = new ViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ThrowOnInvalidPropertyName = expected;
            actual = target.ThrowOnInvalidPropertyName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainFaces
        ///</summary>
        [TestMethod()]
        public void TrainFacesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.TrainFaces = expected;
            actual = target.TrainFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainImages
        ///</summary>
        [TestMethod()]
        public void TrainImagesTest()
        {
            ViewModelBase target = CreateViewModelBase(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.TrainImages = expected;
            actual = target.TrainImages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
