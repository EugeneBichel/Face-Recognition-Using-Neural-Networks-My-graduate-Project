using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceImagesModel;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizeClassViewModelTest and is intended
    ///to contain all RecognizeClassViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizeClassViewModelTest
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
        ///A test for RecognizeClassViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizeClassViewModelConstructorTest()
        {
            RecognizeClassViewModel target = new RecognizeClassViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IsRecognized
        ///</summary>
        [TestMethod()]
        public void IsRecognizedTest()
        {
            RecognizeClassViewModel target = new RecognizeClassViewModel(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsRecognized = expected;
            actual = target.IsRecognized;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognizedFaces
        ///</summary>
        [TestMethod()]
        public void RecognizedFacesTest()
        {
            RecognizeClassViewModel target = new RecognizeClassViewModel(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> actual;
            target.RecognizedFaces = expected;
            actual = target.RecognizedFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TestFace
        ///</summary>
        [TestMethod()]
        public void TestFaceTest()
        {
            RecognizeClassViewModel target = new RecognizeClassViewModel(); // TODO: Initialize to an appropriate value
            FaceImage expected = null; // TODO: Initialize to an appropriate value
            FaceImage actual;
            target.TestFace = expected;
            actual = target.TestFace;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
