using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceRecognition.ViewModel.CustomEventArgs;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizeMethodsViewModelBaseTest and is intended
    ///to contain all RecognizeMethodsViewModelBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizeMethodsViewModelBaseTest
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


        internal virtual RecognizeMethodsViewModelBase_Accessor CreateRecognizeMethodsViewModelBase_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            RecognizeMethodsViewModelBase_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for GetRecognizeFace
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GetRecognizeFaceTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeMethodsViewModelBase_Accessor target = new RecognizeMethodsViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            target.GetRecognizeFace();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnDrawRecognizedFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnDrawRecognizedFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeMethodsViewModelBase_Accessor target = new RecognizeMethodsViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            double percentRecFaces = 0F; // TODO: Initialize to an appropriate value
            target.OnDrawRecognizedFaces(percentRecFaces);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual RecognizeMethodsViewModelBase CreateRecognizeMethodsViewModelBase()
        {
            // TODO: Instantiate an appropriate concrete class.
            RecognizeMethodsViewModelBase target = null;
            return target;
        }

        /// <summary>
        ///A test for Recognize
        ///</summary>
        [TestMethod()]
        public void RecognizeTest()
        {
            RecognizeMethodsViewModelBase target = CreateRecognizeMethodsViewModelBase(); // TODO: Initialize to an appropriate value
            target.Recognize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionRecognitionMethodViewModel_BeginRecognitionEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectionRecognitionMethodViewModel_BeginRecognitionEventTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeMethodsViewModelBase_Accessor target = new RecognizeMethodsViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.SelectionRecognitionMethodViewModel_BeginRecognitionEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionRecognitionMethodViewModel_GetSelectedRecognizeMethodEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectionRecognitionMethodViewModel_GetSelectedRecognizeMethodEventTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeMethodsViewModelBase_Accessor target = new RecognizeMethodsViewModelBase_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RecognizeMethodEventArgs e = null; // TODO: Initialize to an appropriate value
            target.SelectionRecognitionMethodViewModel_GetSelectedRecognizeMethodEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Train
        ///</summary>
        [TestMethod()]
        public void TrainTest()
        {
            RecognizeMethodsViewModelBase target = CreateRecognizeMethodsViewModelBase(); // TODO: Initialize to an appropriate value
            target.Train();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeTimeValue
        ///</summary>
        [TestMethod()]
        public void RecognizeTimeValueTest()
        {
            RecognizeMethodsViewModelBase target = CreateRecognizeMethodsViewModelBase(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.RecognizeTimeValue = expected;
            actual = target.RecognizeTimeValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainStatus
        ///</summary>
        [TestMethod()]
        public void TrainStatusTest()
        {
            RecognizeMethodsViewModelBase target = CreateRecognizeMethodsViewModelBase(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TrainStatus = expected;
            actual = target.TrainStatus;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainTimeValue
        ///</summary>
        [TestMethod()]
        public void TrainTimeValueTest()
        {
            RecognizeMethodsViewModelBase target = CreateRecognizeMethodsViewModelBase(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.TrainTimeValue = expected;
            actual = target.TrainTimeValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
