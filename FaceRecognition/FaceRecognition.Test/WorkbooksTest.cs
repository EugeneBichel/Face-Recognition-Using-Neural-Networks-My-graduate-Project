﻿using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for WorkbooksTest and is intended
    ///to contain all WorkbooksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkbooksTest
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


        internal virtual Workbooks CreateWorkbooks()
        {
            // TODO: Instantiate an appropriate concrete class.
            Workbooks target = null;
            return target;
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            Workbooks target = CreateWorkbooks(); // TODO: Initialize to an appropriate value
            object Template = null; // TODO: Initialize to an appropriate value
            Workbook expected = null; // TODO: Initialize to an appropriate value
            Workbook actual;
            actual = target.Add(Template);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
