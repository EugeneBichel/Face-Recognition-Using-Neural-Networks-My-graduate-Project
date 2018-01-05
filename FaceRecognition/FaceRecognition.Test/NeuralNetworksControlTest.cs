using FaceRecognition.Controls.RecognizeMehodsControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for NeuralNetworksControlTest and is intended
    ///to contain all NeuralNetworksControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NeuralNetworksControlTest
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
        ///A test for TrainButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void TrainButton_ClickTest()
        {
            NeuralNetworksControl_Accessor target = new NeuralNetworksControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.TrainButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new NeuralNetworksControl(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RecognizeButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void RecognizeButton_ClickTest()
        {
            NeuralNetworksControl_Accessor target = new NeuralNetworksControl_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.RecognizeButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            NeuralNetworksControl target = new NeuralNetworksControl(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NeuralNetworksControl Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralNetworksControlConstructorTest()
        {
            NeuralNetworksControl target = new NeuralNetworksControl();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for NeuralNetworksControl Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralNetworksControlConstructorTest1()
        {
            int selectedMethod = 0; // TODO: Initialize to an appropriate value
            NeuralNetworksControl target = new NeuralNetworksControl(selectedMethod);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
