using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceImagesModel;
using System.Collections.Generic;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SelectionTrainTestImagesViewModelTest and is intended
    ///to contain all SelectionTrainTestImagesViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectionTrainTestImagesViewModelTest
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


        /// <summary>
        ///A test for SelectionTrainTestImagesViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void SelectionTrainTestImagesViewModelConstructorTest()
        {
            SelectionTrainTestImagesViewModel target = new SelectionTrainTestImagesViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetFaceImages
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GetFaceImagesTest()
        {
            SelectionTrainTestImagesViewModel_Accessor target = new SelectionTrainTestImagesViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.GetFaceImages();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainWindow_TrainAndTestDataSavedEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void MainWindow_TrainAndTestDataSavedEventTest()
        {
            SelectionTrainTestImagesViewModel_Accessor target = new SelectionTrainTestImagesViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.MainWindow_TrainAndTestDataSavedEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionDataBaseViewModel_SelectedDataBaseEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectionDataBaseViewModel_SelectedDataBaseEventTest()
        {
            SelectionTrainTestImagesViewModel_Accessor target = new SelectionTrainTestImagesViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SelectedFaceDbEventArgs e = null; // TODO: Initialize to an appropriate value
            target.SelectionDataBaseViewModel_SelectedDataBaseEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetTestImages
        ///</summary>
        [TestMethod()]
        public void SetTestImagesTest()
        {
            SelectionTrainTestImagesViewModel target = new SelectionTrainTestImagesViewModel(); // TODO: Initialize to an appropriate value
            List<FaceImage> testImages = null; // TODO: Initialize to an appropriate value
            target.SetTestImages(testImages);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetTrainImages
        ///</summary>
        [TestMethod()]
        public void SetTrainImagesTest()
        {
            SelectionTrainTestImagesViewModel target = new SelectionTrainTestImagesViewModel(); // TODO: Initialize to an appropriate value
            List<FaceImage> trainImages = null; // TODO: Initialize to an appropriate value
            target.SetTrainImages(trainImages);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NumberTestFaceImages
        ///</summary>
        [TestMethod()]
        public void NumberTestFaceImagesTest()
        {
            SelectionTrainTestImagesViewModel target = new SelectionTrainTestImagesViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberTestFaceImages = expected;
            actual = target.NumberTestFaceImages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumberTrainFaceImages
        ///</summary>
        [TestMethod()]
        public void NumberTrainFaceImagesTest()
        {
            SelectionTrainTestImagesViewModel target = new SelectionTrainTestImagesViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberTrainFaceImages = expected;
            actual = target.NumberTrainFaceImages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
