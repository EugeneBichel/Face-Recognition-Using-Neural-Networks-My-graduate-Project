using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SelectionRecognitionMethodViewModelTest and is intended
    ///to contain all SelectionRecognitionMethodViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectionRecognitionMethodViewModelTest
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
        ///A test for SelectionRecognitionMethodViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void SelectionRecognitionMethodViewModelConstructorTest()
        {
            SelectionRecognitionMethodViewModel target = new SelectionRecognitionMethodViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for OnGetSelectedRecMethod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnGetSelectedRecMethodTest()
        {
            SelectionRecognitionMethodViewModel_Accessor target = new SelectionRecognitionMethodViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.OnGetSelectedRecMethod();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveMethod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveMethodTest()
        {
            SelectionRecognitionMethodViewModel_Accessor target = new SelectionRecognitionMethodViewModel_Accessor(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            target.SaveMethod(name);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveRecognitionMethod
        ///</summary>
        [TestMethod()]
        public void SaveRecognitionMethodTest()
        {
            SelectionRecognitionMethodViewModel target = new SelectionRecognitionMethodViewModel(); // TODO: Initialize to an appropriate value
            string selectedMethod = string.Empty; // TODO: Initialize to an appropriate value
            target.SaveRecognitionMethod(selectedMethod);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognitionMethod
        ///</summary>
        [TestMethod()]
        public void RecognitionMethodTest()
        {
            SelectionRecognitionMethodViewModel target = new SelectionRecognitionMethodViewModel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.RecognitionMethod = expected;
            actual = target.RecognitionMethod;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognitionMethods
        ///</summary>
        [TestMethod()]
        public void RecognitionMethodsTest()
        {
            SelectionRecognitionMethodViewModel target = new SelectionRecognitionMethodViewModel(); // TODO: Initialize to an appropriate value
            ObservableCollection<string> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<string> actual;
            target.RecognitionMethods = expected;
            actual = target.RecognitionMethods;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainStatus
        ///</summary>
        [TestMethod()]
        public void TrainStatusTest()
        {
            SelectionRecognitionMethodViewModel target = new SelectionRecognitionMethodViewModel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TrainStatus = expected;
            actual = target.TrainStatus;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
