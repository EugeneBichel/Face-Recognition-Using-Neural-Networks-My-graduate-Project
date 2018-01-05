using FaceRecognition.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Markup;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for RecognizePanelControlTest and is intended
    ///to contain all RecognizePanelControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecognizePanelControlTest
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
            IComponentConnector target = new RecognizePanelControl(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEventTest()
        {
            RecognizePanelControl_Accessor target = new RecognizePanelControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.SelectionRecognitionMethodControl_ClearRecognizedFacesPanelEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeMethodsViewModelBase_DrawRecongitionResultsEventTest()
        {
            RecognizePanelControl_Accessor target = new RecognizePanelControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            RecognizePanelControl target = new RecognizePanelControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FillPanel
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void FillPanelTest()
        {
            RecognizePanelControl_Accessor target = new RecognizePanelControl_Accessor(); // TODO: Initialize to an appropriate value
            target.FillPanel();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizePanelControl Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizePanelControlConstructorTest()
        {
            RecognizePanelControl target = new RecognizePanelControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RecognizePanelControl Constructor
        ///</summary>
        [TestMethod()]
        public void RecognizePanelControlConstructorTest1()
        {
            RecognizePanelViewModel recognizePanelViewModel = null; // TODO: Initialize to an appropriate value
            RecognizePanelControl target = new RecognizePanelControl(recognizePanelViewModel);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
