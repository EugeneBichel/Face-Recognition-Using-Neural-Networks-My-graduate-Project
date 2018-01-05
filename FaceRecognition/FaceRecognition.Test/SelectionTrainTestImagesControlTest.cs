using FaceRecognition.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SelectionTrainTestImagesControlTest and is intended
    ///to contain all SelectionTrainTestImagesControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectionTrainTestImagesControlTest
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
        ///A test for selectOddImageBtn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void selectOddImageBtn_ClickTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.selectOddImageBtn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for selectEvenImageBtn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void selectEvenImageBtn_ClickTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.selectEvenImageBtn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for delSelTrainItemsBtn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void delSelTrainItemsBtn_ClickTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.delSelTrainItemsBtn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for delSelTestItemsBtn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void delSelTestItemsBtn_ClickTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.delSelTestItemsBtn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TrainImageListView_SelectionChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void TrainImageListView_SelectionChangedTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SelectionChangedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.TrainImageListView_SelectionChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TestImageListView_SelectionChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void TestImageListView_SelectionChangedTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SelectionChangedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.TestImageListView_SelectionChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new SelectionTrainTestImagesControl(); // TODO: Initialize to an appropriate value
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
            SelectionTrainTestImagesControl target = new SelectionTrainTestImagesControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DropTrainImage
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void DropTrainImageTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DragEventArgs e = null; // TODO: Initialize to an appropriate value
            target.DropTrainImage(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DropTestImage
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void DropTestImageTest()
        {
            SelectionTrainTestImagesControl_Accessor target = new SelectionTrainTestImagesControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DragEventArgs e = null; // TODO: Initialize to an appropriate value
            target.DropTestImage(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionTrainTestImagesControl Constructor
        ///</summary>
        [TestMethod()]
        public void SelectionTrainTestImagesControlConstructorTest()
        {
            SelectionTrainTestImagesControl target = new SelectionTrainTestImagesControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
