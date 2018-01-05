using FaceRecognition.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for PreprocessingPanelControlTest and is intended
    ///to contain all PreprocessingPanelControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PreprocessingPanelControlTest
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
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new PreprocessingPanelControl(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnPreprocessedPanelVisibled
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnPreprocessedPanelVisibledTest()
        {
            PreprocessingPanelControl_Accessor target = new PreprocessingPanelControl_Accessor(); // TODO: Initialize to an appropriate value
            target.OnPreprocessedPanelVisibled();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnFacesGot
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnFacesGotTest()
        {
            PreprocessingPanelControl_Accessor target = new PreprocessingPanelControl_Accessor(); // TODO: Initialize to an appropriate value
            target.OnFacesGot();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnDataSaved
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnDataSavedTest()
        {
            PreprocessingPanelControl_Accessor target = new PreprocessingPanelControl_Accessor(); // TODO: Initialize to an appropriate value
            target.OnDataSaved();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainWindow_ImagesPreprocessedEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void MainWindow_ImagesPreprocessedEventTest()
        {
            PreprocessingPanelControl_Accessor target = new PreprocessingPanelControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.MainWindow_ImagesPreprocessedEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            PreprocessingPanelControl target = new PreprocessingPanelControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PreprocessingPanelControl Constructor
        ///</summary>
        [TestMethod()]
        public void PreprocessingPanelControlConstructorTest()
        {
            PreprocessingPanelControl target = new PreprocessingPanelControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
