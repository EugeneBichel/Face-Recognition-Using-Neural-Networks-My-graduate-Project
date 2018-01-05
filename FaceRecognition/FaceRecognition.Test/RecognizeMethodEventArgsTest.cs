using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizeMethodEventArgsTest and is intended
    ///to contain all RecognizeMethodEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizeMethodEventArgsTest
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
        ///A test for RecognizeMethodEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizeMethodEventArgsConstructorTest()
        {
            string selectedMethod = string.Empty; // TODO: Initialize to an appropriate value
            RecognizeMethodEventArgs target = new RecognizeMethodEventArgs(selectedMethod);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SelectedMethod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectedMethodTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RecognizeMethodEventArgs_Accessor target = new RecognizeMethodEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SelectedMethod = expected;
            actual = target.SelectedMethod;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
