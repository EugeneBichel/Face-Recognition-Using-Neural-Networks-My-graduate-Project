using FaceRecognition.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceRecognition.RecognitionMethods.MethodModel;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for ExcelExporterTest and is intended
    ///to contain all ExcelExporterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExcelExporterTest
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
        ///A test for ReleaseObject
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ReleaseObjectTest()
        {
            ExcelExporter_Accessor target = new ExcelExporter_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.ReleaseObject(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExportDetails
        ///</summary>
        [TestMethod()]
        public void ExportDetailsTest()
        {
            ExcelExporter target = new ExcelExporter(); // TODO: Initialize to an appropriate value
            ObservableCollection<RecognitionMethodModel> methods = null; // TODO: Initialize to an appropriate value
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            target.ExportDetails(methods, fileName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExcelExporter Constructor
        ///</summary>
        [TestMethod()]
        public void ExcelExporterConstructorTest()
        {
            ExcelExporter target = new ExcelExporter();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
