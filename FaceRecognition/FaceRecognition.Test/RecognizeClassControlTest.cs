using FaceRecognition.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceRecognition.ViewModel;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizeClassControlTest and is intended
    ///to contain all RecognizeClassControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizeClassControlTest
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
        ///A test for RecognizedClassViewModel
        ///</summary>
        [TestMethod()]
        public void RecognizedClassViewModelTest()
        {
            RecognizeClassControl target = new RecognizeClassControl(); // TODO: Initialize to an appropriate value
            RecognizeClassViewModel actual;
            actual = target.RecognizedClassViewModel;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new RecognizeClassControl(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            RecognizeClassControl target = new RecognizeClassControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeClassControl Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizeClassControlConstructorTest()
        {
            RecognizeClassControl target = new RecognizeClassControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
