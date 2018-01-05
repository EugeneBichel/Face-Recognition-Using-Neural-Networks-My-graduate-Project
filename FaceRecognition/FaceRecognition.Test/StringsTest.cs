using FaceRecognition.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Resources;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for StringsTest and is intended
    ///to contain all StringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringsTest
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
        ///A test for Strings Constructor
        ///</summary>
        [TestMethod()]
        public void StringsConstructorTest()
        {
            Strings target = new Strings();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AboutWindow_Title
        ///</summary>
        [TestMethod()]
        public void AboutWindow_TitleTest()
        {
            string actual;
            actual = Strings.AboutWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Culture
        ///</summary>
        [TestMethod()]
        public void CultureTest()
        {
            CultureInfo expected = null; // TODO: Initialize to an appropriate value
            CultureInfo actual;
            Strings.Culture = expected;
            actual = Strings.Culture;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExtractFeaturesWindow_Title
        ///</summary>
        [TestMethod()]
        public void ExtractFeaturesWindow_TitleTest()
        {
            string actual;
            actual = Strings.ExtractFeaturesWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FaceDetectionWindow_Title
        ///</summary>
        [TestMethod()]
        public void FaceDetectionWindow_TitleTest()
        {
            string actual;
            actual = Strings.FaceDetectionWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_ExcelResults
        ///</summary>
        [TestMethod()]
        public void FileName_ExcelResultsTest()
        {
            string actual;
            actual = Strings.FileName_ExcelResults;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_OneLayer_NeuronNet
        ///</summary>
        [TestMethod()]
        public void FileName_OneLayer_NeuronNetTest()
        {
            string actual;
            actual = Strings.FileName_OneLayer_NeuronNet;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_RecognizedFaces
        ///</summary>
        [TestMethod()]
        public void FileName_RecognizedFacesTest()
        {
            string actual;
            actual = Strings.FileName_RecognizedFaces;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_SelectedRecognitionMethods
        ///</summary>
        [TestMethod()]
        public void FileName_SelectedRecognitionMethodsTest()
        {
            string actual;
            actual = Strings.FileName_SelectedRecognitionMethods;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_TestFaces
        ///</summary>
        [TestMethod()]
        public void FileName_TestFacesTest()
        {
            string actual;
            actual = Strings.FileName_TestFaces;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_TestImages
        ///</summary>
        [TestMethod()]
        public void FileName_TestImagesTest()
        {
            string actual;
            actual = Strings.FileName_TestImages;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_ThreeLayer_NeuronNet
        ///</summary>
        [TestMethod()]
        public void FileName_ThreeLayer_NeuronNetTest()
        {
            string actual;
            actual = Strings.FileName_ThreeLayer_NeuronNet;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_TrainFaces
        ///</summary>
        [TestMethod()]
        public void FileName_TrainFacesTest()
        {
            string actual;
            actual = Strings.FileName_TrainFaces;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_TrainImages
        ///</summary>
        [TestMethod()]
        public void FileName_TrainImagesTest()
        {
            string actual;
            actual = Strings.FileName_TrainImages;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileName_TwoLayer_NeuronNet
        ///</summary>
        [TestMethod()]
        public void FileName_TwoLayer_NeuronNetTest()
        {
            string actual;
            actual = Strings.FileName_TwoLayer_NeuronNet;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MainWindow_Title
        ///</summary>
        [TestMethod()]
        public void MainWindow_TitleTest()
        {
            string actual;
            actual = Strings.MainWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MainWindow_Toolbar_ImagesDbButon_Tooltip
        ///</summary>
        [TestMethod()]
        public void MainWindow_Toolbar_ImagesDbButon_TooltipTest()
        {
            string actual;
            actual = Strings.MainWindow_Toolbar_ImagesDbButon_Tooltip;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PreprocessingWaitWindow_ProgressBar_Title
        ///</summary>
        [TestMethod()]
        public void PreprocessingWaitWindow_ProgressBar_TitleTest()
        {
            string actual;
            actual = Strings.PreprocessingWaitWindow_ProgressBar_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PreprocessingWaitWindow_Title
        ///</summary>
        [TestMethod()]
        public void PreprocessingWaitWindow_TitleTest()
        {
            string actual;
            actual = Strings.PreprocessingWaitWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognitionMethodsWindow_Title
        ///</summary>
        [TestMethod()]
        public void RecognitionMethodsWindow_TitleTest()
        {
            string actual;
            actual = Strings.RecognitionMethodsWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResourceManager
        ///</summary>
        [TestMethod()]
        public void ResourceManagerTest()
        {
            ResourceManager actual;
            actual = Strings.ResourceManager;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrainAndTestImagesWindow_Title
        ///</summary>
        [TestMethod()]
        public void TrainAndTestImagesWindow_TitleTest()
        {
            string actual;
            actual = Strings.TrainAndTestImagesWindow_Title;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
