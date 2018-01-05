using FaceRecognition.RecognitionMethods.NeuralNetworks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceImagesModel;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for ExtractFeaturesTest and is intended
    ///to contain all ExtractFeaturesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExtractFeaturesTest
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
        ///A test for ExtractFeatures Constructor
        ///</summary>
        [TestMethod()]
        public void ExtractFeaturesConstructorTest()
        {
            ObservableCollection<FaceImage> trainFaces = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> testFaces = null; // TODO: Initialize to an appropriate value
            ExtractFeatures target = new ExtractFeatures(trainFaces, testFaces);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ExtractFeatures Constructor
        ///</summary>
        [TestMethod()]
        public void ExtractFeaturesConstructorTest1()
        {
            ExtractFeatures target = new ExtractFeatures();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateVectors
        ///</summary>
        [TestMethod()]
        public void CreateVectorsTest()
        {
            ExtractFeatures target = new ExtractFeatures(); // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> trainFaces = null; // TODO: Initialize to an appropriate value
            ObservableCollection<FaceImage> testFaces = null; // TODO: Initialize to an appropriate value
            target.CreateVectors(trainFaces, testFaces);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateVectors
        ///</summary>
        [TestMethod()]
        public void CreateVectorsTest1()
        {
            ExtractFeatures target = new ExtractFeatures(); // TODO: Initialize to an appropriate value
            target.CreateVectors();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateVectorsAfterFFT
        ///</summary>
        [TestMethod()]
        public void CreateVectorsAfterFFTTest()
        {
            ExtractFeatures target = new ExtractFeatures(); // TODO: Initialize to an appropriate value
            target.CreateVectorsAfterFFT();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindMaxValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void FindMaxValueTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] vector = null; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.FindMaxValue(vector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindMinValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void FindMinValueTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] vector = null; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.FindMinValue(vector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDirectFFT
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GetDirectFFTTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] vector = null; // TODO: Initialize to an appropriate value
            alglib.complex[] expected = null; // TODO: Initialize to an appropriate value
            alglib.complex[] actual;
            actual = target.GetDirectFFT(vector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetInvFFT
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GetInvFFTTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            alglib.complex[] dirVector = null; // TODO: Initialize to an appropriate value
            double[] expected = null; // TODO: Initialize to an appropriate value
            double[] actual;
            actual = target.GetInvFFT(dirVector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImageToVector
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ImageToVectorTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            string fullNameImage = string.Empty; // TODO: Initialize to an appropriate value
            double[] expected = null; // TODO: Initialize to an appropriate value
            double[] actual;
            actual = target.ImageToVector(fullNameImage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NormProcess
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void NormProcessTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] invVector = null; // TODO: Initialize to an appropriate value
            double[] expected = null; // TODO: Initialize to an appropriate value
            double[] actual;
            actual = target.NormProcess(invVector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProcessVectorForInputNet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ProcessVectorForInputNetTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] normVector = null; // TODO: Initialize to an appropriate value
            double[] expected = null; // TODO: Initialize to an appropriate value
            double[] actual;
            actual = target.ProcessVectorForInputNet(normVector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReverseProcessVectorFromOutNet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ReverseProcessVectorFromOutNetTest()
        {
            ExtractFeatures_Accessor target = new ExtractFeatures_Accessor(); // TODO: Initialize to an appropriate value
            double[] outVector = null; // TODO: Initialize to an appropriate value
            double[] expected = null; // TODO: Initialize to an appropriate value
            double[] actual;
            actual = target.ReverseProcessVectorFromOutNet(outVector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveTrainTestFaces
        ///</summary>
        [TestMethod()]
        public void SaveTrainTestFacesTest()
        {
            ExtractFeatures target = new ExtractFeatures(); // TODO: Initialize to an appropriate value
            target.SaveTrainTestFaces();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
