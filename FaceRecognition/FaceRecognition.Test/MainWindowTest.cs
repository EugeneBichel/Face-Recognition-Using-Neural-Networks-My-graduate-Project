using FaceRecognition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using FaceRecognition.ViewModel.CustomEventArgs;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for MainWindowTest and is intended
    ///to contain all MainWindowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainWindowTest
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
        ///A test for OnDataSaved
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnDataSavedTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            target.OnDataSaved();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainWindow_Loaded
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void MainWindow_LoadedTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.MainWindow_Loaded(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            MainWindow target = new MainWindow(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GoPreprocBtn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GoPreprocBtn_ClickTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GoPreprocBtn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainWindow Constructor
        ///</summary>
        [TestMethod()]
        public void MainWindowConstructorTest()
        {
            MainWindow target = new MainWindow();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for _CreateDelegate
        ///</summary>
        [TestMethod()]
        public void _CreateDelegateTest()
        {
            MainWindow target = new MainWindow(); // TODO: Initialize to an appropriate value
            Type delegateType = null; // TODO: Initialize to an appropriate value
            string handler = string.Empty; // TODO: Initialize to an appropriate value
            Delegate expected = null; // TODO: Initialize to an appropriate value
            Delegate actual;
            actual = target._CreateDelegate(delegateType, handler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Window_Closed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void Window_ClosedTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Window_Closed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TrainAndTestFaceViewModel_ControlStateChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void TrainAndTestFaceViewModel_ControlStateChangedTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ControlReadyEventArgs e = null; // TODO: Initialize to an appropriate value
            target.TrainAndTestFaceViewModel_ControlStateChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new MainWindow(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeMethodsViewModelBase_DrawRecongitionResultsEventTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RecognizeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.RecognizeMethodsViewModelBase_DrawRecongitionResultsEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeMethodControlBase_RecognizePanelVisibleEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeMethodControlBase_RecognizePanelVisibleEventTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.RecognizeMethodControlBase_RecognizePanelVisibleEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PreprocessingPanelControl_PreprocessingPanelVisibleEvent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void PreprocessingPanelControl_PreprocessingPanelVisibleEventTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PreprocessingPanelControl_PreprocessingPanelVisibleEvent(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnImagesPreprocessed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnImagesPreprocessedTest()
        {
            MainWindow_Accessor target = new MainWindow_Accessor(); // TODO: Initialize to an appropriate value
            target.OnImagesPreprocessed();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
