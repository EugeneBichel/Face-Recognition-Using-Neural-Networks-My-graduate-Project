using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizeEventArgsTest and is intended
    ///to contain all RecognizeEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizeEventArgsTest
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
        ///A test for RecognizeEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizeEventArgsConstructorTest()
        {
            string methodName = string.Empty; // TODO: Initialize to an appropriate value
            double timeValue = 0F; // TODO: Initialize to an appropriate value
            double percentRecFaces = 0F; // TODO: Initialize to an appropriate value
            RecognizeEventArgs target = new RecognizeEventArgs(methodName, timeValue, percentRecFaces);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MethodName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void MethodNameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs_Accessor target = new RecognizeEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.MethodName = expected;
            actual = target.MethodName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PercentRecFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void PercentRecFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs_Accessor target = new RecognizeEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.PercentRecFaces = expected;
            actual = target.PercentRecFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognizeTime
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeTimeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs_Accessor target = new RecognizeEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.RecognizeTime = expected;
            actual = target.RecognizeTime;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
