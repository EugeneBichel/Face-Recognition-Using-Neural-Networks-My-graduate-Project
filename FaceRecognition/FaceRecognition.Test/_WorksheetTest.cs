using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for _WorksheetTest and is intended
    ///to contain all _WorksheetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _WorksheetTest
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


        internal virtual _Worksheet Create_Worksheet()
        {
            // TODO: Instantiate an appropriate concrete class.
            _Worksheet target = null;
            return target;
        }

        /// <summary>
        ///A test for Cells
        ///</summary>
        [TestMethod()]
        public void CellsTest()
        {
            _Worksheet target = Create_Worksheet(); // TODO: Initialize to an appropriate value
            Range actual;
            actual = target.Cells;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
