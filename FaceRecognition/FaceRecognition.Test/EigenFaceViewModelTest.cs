using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Timers;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for EigenFaceViewModelTest and is intended
    ///to contain all EigenFaceViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EigenFaceViewModelTest
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
        ///A test for EigenFaceViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void EigenFaceViewModelConstructorTest()
        {
            EigenFaceViewModel target = new EigenFaceViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Recognize
        ///</summary>
        [TestMethod()]
        public void RecognizeTest()
        {
            EigenFaceViewModel target = new EigenFaceViewModel(); // TODO: Initialize to an appropriate value
            target.Recognize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ThreadPoolTrain
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ThreadPoolTrainTest()
        {
            EigenFaceViewModel_Accessor target = new EigenFaceViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.ThreadPoolTrain();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Train
        ///</summary>
        [TestMethod()]
        public void TrainTest()
        {
            EigenFaceViewModel target = new EigenFaceViewModel(); // TODO: Initialize to an appropriate value
            target.Train();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for _recTimer_Elapsed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void _recTimer_ElapsedTest()
        {
            EigenFaceViewModel_Accessor target = new EigenFaceViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ElapsedEventArgs e = null; // TODO: Initialize to an appropriate value
            target._recTimer_Elapsed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for _trainTimer_Elapsed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void _trainTimer_ElapsedTest()
        {
            EigenFaceViewModel_Accessor target = new EigenFaceViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ElapsedEventArgs e = null; // TODO: Initialize to an appropriate value
            target._trainTimer_Elapsed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
