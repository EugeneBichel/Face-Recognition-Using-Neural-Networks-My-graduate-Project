using FaceRecognition.ViewModel.CustomEventArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SelectedFaceDbEventArgsTest and is intended
    ///to contain all SelectedFaceDbEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectedFaceDbEventArgsTest
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
        ///A test for SelectedFaceDbEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void SelectedFaceDbEventArgsConstructorTest()
        {
            int selectedId = 0; // TODO: Initialize to an appropriate value
            SelectedFaceDbEventArgs target = new SelectedFaceDbEventArgs(selectedId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SelectedId
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectedIdTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SelectedFaceDbEventArgs_Accessor target = new SelectedFaceDbEventArgs_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.SelectedId = expected;
            actual = target.SelectedId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
