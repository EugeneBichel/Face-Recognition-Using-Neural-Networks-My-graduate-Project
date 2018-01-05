using FaceRecognition.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for SelectionDataBaseViewModelTest and is intended
    ///to contain all SelectionDataBaseViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectionDataBaseViewModelTest
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
        ///A test for SelectionDataBaseViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void SelectionDataBaseViewModelConstructorTest()
        {
            SelectionDataBaseViewModel target = new SelectionDataBaseViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for OnSelectedDataBase
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void OnSelectedDataBaseTest()
        {
            SelectionDataBaseViewModel_Accessor target = new SelectionDataBaseViewModel_Accessor(); // TODO: Initialize to an appropriate value
            int selectedId = 0; // TODO: Initialize to an appropriate value
            target.OnSelectedDataBase(selectedId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectDb
        ///</summary>
        [TestMethod()]
        public void SelectDbTest()
        {
            SelectionDataBaseViewModel target = new SelectionDataBaseViewModel(); // TODO: Initialize to an appropriate value
            int selectedFaceDb = 0; // TODO: Initialize to an appropriate value
            target.SelectDb(selectedFaceDb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DataBaseNames
        ///</summary>
        [TestMethod()]
        public void DataBaseNamesTest()
        {
            SelectionDataBaseViewModel target = new SelectionDataBaseViewModel(); // TODO: Initialize to an appropriate value
            ObservableCollection<string> actual;
            actual = target.DataBaseNames;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumberFaceImages
        ///</summary>
        [TestMethod()]
        public void NumberFaceImagesTest()
        {
            SelectionDataBaseViewModel target = new SelectionDataBaseViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumberFaceImages = expected;
            actual = target.NumberFaceImages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
