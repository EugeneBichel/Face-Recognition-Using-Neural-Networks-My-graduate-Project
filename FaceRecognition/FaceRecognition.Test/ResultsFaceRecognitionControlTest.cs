using FaceRecognition.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for ResultsFaceRecognitionControlTest and is intended
    ///to contain all ResultsFaceRecognitionControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ResultsFaceRecognitionControlTest
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
        ///A test for lstResultRecognitionMethods_SelectionChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void lstResultRecognitionMethods_SelectionChangedTest()
        {
            ResultsFaceRecognitionControl_Accessor target = new ResultsFaceRecognitionControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SelectionChangedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.lstResultRecognitionMethods_SelectionChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for exportExcelButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void exportExcelButton_ClickTest()
        {
            ResultsFaceRecognitionControl_Accessor target = new ResultsFaceRecognitionControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.exportExcelButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new ResultsFaceRecognitionControl(); // TODO: Initialize to an appropriate value
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
            ResultsFaceRecognitionControl target = new ResultsFaceRecognitionControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ResultsFaceRecognitionControl Constructor
        ///</summary>
        [TestMethod()]
        public void ResultsFaceRecognitionControlConstructorTest()
        {
            ResultsFaceRecognitionControl target = new ResultsFaceRecognitionControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
