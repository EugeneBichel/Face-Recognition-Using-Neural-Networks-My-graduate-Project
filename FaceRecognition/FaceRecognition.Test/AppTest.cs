using FaceRecognition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Threading;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for AppTest and is intended
    ///to contain all AppTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AppTest
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
        ///A test for Main
        ///</summary>
        [TestMethod()]
        public void MainTest()
        {
            App.Main();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            App target = new App(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HandleException
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void HandleExceptionTest()
        {
            Exception ex = null; // TODO: Initialize to an appropriate value
            string policy = string.Empty; // TODO: Initialize to an appropriate value
            App_Accessor.HandleException(ex, policy);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Current_DispatcherUnhandledException
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void Current_DispatcherUnhandledExceptionTest()
        {
            object sender = null; // TODO: Initialize to an appropriate value
            DispatcherUnhandledExceptionEventArgs e = null; // TODO: Initialize to an appropriate value
            App_Accessor.Current_DispatcherUnhandledException(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CurrentDomain_UnhandledException
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void CurrentDomain_UnhandledExceptionTest()
        {
            object sender = null; // TODO: Initialize to an appropriate value
            UnhandledExceptionEventArgs e = null; // TODO: Initialize to an appropriate value
            App_Accessor.CurrentDomain_UnhandledException(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Application_DispatcherUnhandledException
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void Application_DispatcherUnhandledExceptionTest()
        {
            App_Accessor target = new App_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DispatcherUnhandledExceptionEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Application_DispatcherUnhandledException(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for App Constructor
        ///</summary>
        [TestMethod()]
        public void AppConstructorTest()
        {
            App target = new App();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
