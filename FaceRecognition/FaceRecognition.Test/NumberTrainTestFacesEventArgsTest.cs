using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for NumberTrainTestFacesEventArgsTest and is intended
    ///to contain all NumberTrainTestFacesEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumberTrainTestFacesEventArgsTest
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
        ///A test for NumberTrainTestFacesEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void NumberTrainTestFacesEventArgsConstructorTest()
        {
            int numberTrainFaces = 0; // TODO: Initialize to an appropriate value
            int numberTestFaces = 0; // TODO: Initialize to an appropriate value
            NumberTrainTestFacesEventArgs target = new NumberTrainTestFacesEventArgs(numberTrainFaces, numberTestFaces);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for NumberTestFaces
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void NumberTestFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NumberTrainTestFacesEventArgs_Accessor target = new NumberTrainTestFacesEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("FaceRecognition.exe")]
        public void NumberTrainFacesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NumberTrainTestFacesEventArgs_Accessor target = new NumberTrainTestFacesEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberTrainFaces = expected;
            actual = target.NumberTrainFaces;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
