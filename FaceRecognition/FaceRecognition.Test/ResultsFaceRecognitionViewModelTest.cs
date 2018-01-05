using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.RecognitionMethods.MethodModel;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for ResultsFaceRecognitionViewModelTest and is intended
    ///to contain all ResultsFaceRecognitionViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ResultsFaceRecognitionViewModelTest
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
        ///A test for ResultsFaceRecognitionViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void ResultsFaceRecognitionViewModelConstructorTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for OnDrawResultsTable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnDrawResultsTableTest()
        {
            ResultsFaceRecognitionViewModel_Accessor target = new ResultsFaceRecognitionViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.OnDrawResultsTable();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PreprocessingPanelViewModel_SetNumberTrainTestFacesEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void PreprocessingPanelViewModel_SetNumberTrainTestFacesEventTest()
        {
            ResultsFaceRecognitionViewModel_Accessor target = new ResultsFaceRecognitionViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            NumberTrainTestFacesEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PreprocessingPanelViewModel_SetNumberTrainTestFacesEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeMethodsViewModelBase_DrawRecongitionResultsEventTest()
        {
            ResultsFaceRecognitionViewModel_Accessor target = new ResultsFaceRecognitionViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumberTestFaces
        ///</summary>
        [TestMethod()]
        public void NumberTestFacesTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberTestFaces = expected;
            actual = target.NumberTestFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumberTrainFaces
        ///</summary>
        [TestMethod()]
        public void NumberTrainFacesTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberTrainFaces = expected;
            actual = target.NumberTrainFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognitionMethods
        ///</summary>
        [TestMethod()]
        public void RecognitionMethodsTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            ObservableCollection<RecognitionMethodModel> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<RecognitionMethodModel> actual;
            target.RecognitionMethods = expected;
            actual = target.RecognitionMethods;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognitionPercent
        ///</summary>
        [TestMethod()]
        public void RecognitionPercentTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.RecognitionPercent = expected;
            actual = target.RecognitionPercent;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TimeRecognize
        ///</summary>
        [TestMethod()]
        public void TimeRecognizeTest()
        {
            ResultsFaceRecognitionViewModel target = new ResultsFaceRecognitionViewModel(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.TimeRecognize = expected;
            actual = target.TimeRecognize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
