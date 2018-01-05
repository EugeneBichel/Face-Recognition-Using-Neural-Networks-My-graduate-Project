using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for _ApplicationTest and is intended
    ///to contain all _ApplicationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _ApplicationTest
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


        internal virtual _Application Create_Application()
        {
            // TODO: Instantiate an appropriate concrete class.
            _Application target = null;
            return target;
        }

        /// <summary>
        ///A test for Quit
        ///</summary>
        [TestMethod()]
        public void QuitTest()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            target.Quit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Workbooks
        ///</summary>
        [TestMethod()]
        public void WorkbooksTest()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Workbooks actual;
            actual = target.Workbooks;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
