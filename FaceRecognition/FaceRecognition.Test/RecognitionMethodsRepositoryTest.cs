using FaceRecognition.RecognitionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognitionMethodsRepositoryTest and is intended
    ///to contain all RecognitionMethodsRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognitionMethodsRepositoryTest
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
        ///A test for RecognitionMethodsRepository Constructor
        ///</summary>
        [TestMethod()]
        public void RecognitionMethodsRepositoryConstructorTest()
        {
            RecognitionMethodsRepository target = new RecognitionMethodsRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for LoadSelectedRecognitionMethod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadSelectedRecognitionMethodTest()
        {
            RecognitionMethodsRepository_Accessor target = new RecognitionMethodsRepository_Accessor(); // TODO: Initialize to an appropriate value
            target.LoadSelectedRecognitionMethod();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectedMethod
        ///</summary>
        [TestMethod()]
        public void SelectedMethodTest()
        {
            RecognitionMethodsRepository target = new RecognitionMethodsRepository(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SelectedMethod = expected;
            actual = target.SelectedMethod;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
