using FaceRecognition.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SettingsTest and is intended
    ///to contain all SettingsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SettingsTest
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
        ///A test for Settings Constructor
        ///</summary>
        [TestMethod()]
        public void SettingsConstructorTest()
        {
            Settings target = new Settings();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SettingChangingEventHandler
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SettingChangingEventHandlerTest()
        {
            // Private Accessor for FaceRecognition.Properties.Settings is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for FaceRecognition.Properties.Settings is not found. Please reb" +
                    "uild the containing project or run the Publicize.exe manually.");
        }

        /// <summary>
        ///A test for SettingsSavingEventHandler
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SettingsSavingEventHandlerTest()
        {
            // Private Accessor for FaceRecognition.Properties.Settings is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for FaceRecognition.Properties.Settings is not found. Please reb" +
                    "uild the containing project or run the Publicize.exe manually.");
        }

        /// <summary>
        ///A test for Default
        ///</summary>
        [TestMethod()]
        public void DefaultTest()
        {
            Settings actual;
            actual = Settings.Default;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WindowPosition
        ///</summary>
        [TestMethod()]
        public void WindowPositionTest()
        {
            Settings target = new Settings(); // TODO: Initialize to an appropriate value
            Rect expected = new Rect(); // TODO: Initialize to an appropriate value
            Rect actual;
            target.WindowPosition = expected;
            actual = target.WindowPosition;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WindowState
        ///</summary>
        [TestMethod()]
        public void WindowStateTest()
        {
            Settings target = new Settings(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.WindowState = expected;
            actual = target.WindowState;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
