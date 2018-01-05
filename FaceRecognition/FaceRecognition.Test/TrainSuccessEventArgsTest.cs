using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for TrainSuccessEventArgsTest and is intended
    ///to contain all TrainSuccessEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TrainSuccessEventArgsTest
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
        ///A test for TrainSuccessEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void TrainSuccessEventArgsConstructorTest()
        {
            bool isSuccess = false; // TODO: Initialize to an appropriate value
            TrainSuccessEventArgs target = new TrainSuccessEventArgs(isSuccess);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IsSuccess
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void IsSuccessTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TrainSuccessEventArgs_Accessor target = new TrainSuccessEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsSuccess = expected;
            actual = target.IsSuccess;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
