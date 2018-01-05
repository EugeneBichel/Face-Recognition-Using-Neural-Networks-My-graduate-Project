using FaceRecognition.Styles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Markup;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xamlTest and is intended
    ///to contain all d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xamlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xamlTest
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
        ///A test for d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml Constructor
        ///</summary>
        [TestMethod()]
        public void d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xamlConstructorTest()
        {
            d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml target = new d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml target = new d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new d__diplomprojects_diplomproject_facerecognition_styles_itemcontstyle_xaml(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
