using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for _WorkbookTest and is intended
    ///to contain all _WorkbookTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _WorkbookTest
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


        internal virtual _Workbook Create_Workbook()
        {
            // TODO: Instantiate an appropriate concrete class.
            _Workbook target = null;
            return target;
        }

        /// <summary>
        ///A test for Close
        ///</summary>
        [TestMethod()]
        public void CloseTest()
        {
            _Workbook target = Create_Workbook(); // TODO: Initialize to an appropriate value
            object SaveChanges = null; // TODO: Initialize to an appropriate value
            object Filename = null; // TODO: Initialize to an appropriate value
            object RouteWorkbook = null; // TODO: Initialize to an appropriate value
            target.Close(SaveChanges, Filename, RouteWorkbook);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveAs
        ///</summary>
        [TestMethod()]
        public void SaveAsTest()
        {
            _Workbook target = Create_Workbook(); // TODO: Initialize to an appropriate value
            object Filename = null; // TODO: Initialize to an appropriate value
            object FileFormat = null; // TODO: Initialize to an appropriate value
            object Password = null; // TODO: Initialize to an appropriate value
            object WriteResPassword = null; // TODO: Initialize to an appropriate value
            object ReadOnlyRecommended = null; // TODO: Initialize to an appropriate value
            object CreateBackup = null; // TODO: Initialize to an appropriate value
            XlSaveAsAccessMode AccessMode = new XlSaveAsAccessMode(); // TODO: Initialize to an appropriate value
            object ConflictResolution = null; // TODO: Initialize to an appropriate value
            object AddToMru = null; // TODO: Initialize to an appropriate value
            object TextCodepage = null; // TODO: Initialize to an appropriate value
            object TextVisualLayout = null; // TODO: Initialize to an appropriate value
            object Local = null; // TODO: Initialize to an appropriate value
            target.SaveAs(Filename, FileFormat, Password, WriteResPassword, ReadOnlyRecommended, CreateBackup, AccessMode, ConflictResolution, AddToMru, TextCodepage, TextVisualLayout, Local);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Worksheets
        ///</summary>
        [TestMethod()]
        public void WorksheetsTest()
        {
            _Workbook target = Create_Workbook(); // TODO: Initialize to an appropriate value
            Sheets actual;
            actual = target.Worksheets;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
