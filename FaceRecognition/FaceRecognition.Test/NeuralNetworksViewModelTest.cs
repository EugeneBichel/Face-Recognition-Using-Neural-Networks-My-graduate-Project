using FaceRecognition.ViewModel.RecognitionMethodsViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Timers;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation;
using System.Collections.ObjectModel;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for NeuralNetworksViewModelTest and is intended
    ///to contain all NeuralNetworksViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NeuralNetworksViewModelTest
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
        ///A test for NeuralNetworksViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralNetworksViewModelConstructorTest()
        {
            int selectedMethod = 0; // TODO: Initialize to an appropriate value
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(selectedMethod);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for NeuralNetworksViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralNetworksViewModelConstructorTest1()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateNeuralNetwork
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void CreateNeuralNetworkTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.CreateNeuralNetwork();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GenerateTrainingSet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void GenerateTrainingSetTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.GenerateTrainingSet();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadNeuronNet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void LoadNeuronNetTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            int numLayers = 0; // TODO: Initialize to an appropriate value
            target.LoadNeuronNet(numLayers);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Recognize
        ///</summary>
        [TestMethod()]
        public void RecognizeTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            target.Recognize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveNeuronNet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void SaveNeuronNetTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            int numLayers = 0; // TODO: Initialize to an appropriate value
            target.SaveNeuronNet(numLayers);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ThreadPoolTrain
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void ThreadPoolTrainTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            target.ThreadPoolTrain();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Train
        ///</summary>
        [TestMethod()]
        public void TrainTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            target.Train();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateError
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void UpdateErrorTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            double error = 0F; // TODO: Initialize to an appropriate value
            target.UpdateError(error);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateIteration
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void UpdateIterationTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            int iter = 0; // TODO: Initialize to an appropriate value
            target.UpdateIteration(iter);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for _recTimer_Elapsed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void _recTimer_ElapsedTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ElapsedEventArgs e = null; // TODO: Initialize to an appropriate value
            target._recTimer_Elapsed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for _trainTimer_Elapsed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void _trainTimer_ElapsedTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ElapsedEventArgs e = null; // TODO: Initialize to an appropriate value
            target._trainTimer_Elapsed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for neuralNetwork_IterationChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FaceRecognition.exe")]
        public void neuralNetwork_IterationChangedTest()
        {
            NeuralNetworksViewModel_Accessor target = new NeuralNetworksViewModel_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            NeuralEventArgs args = null; // TODO: Initialize to an appropriate value
            target.neuralNetwork_IterationChanged(sender, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Error = expected;
            actual = target.Error;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HiddenUnits
        ///</summary>
        [TestMethod()]
        public void HiddenUnitsTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.HiddenUnits = expected;
            actual = target.HiddenUnits;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InputUnits
        ///</summary>
        [TestMethod()]
        public void InputUnitsTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.InputUnits = expected;
            actual = target.InputUnits;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Iterations
        ///</summary>
        [TestMethod()]
        public void IterationsTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Iterations = expected;
            actual = target.Iterations;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Layers
        ///</summary>
        [TestMethod()]
        public void LayersTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            ObservableCollection<int> expected = null; // TODO: Initialize to an appropriate value
            ObservableCollection<int> actual;
            target.Layers = expected;
            actual = target.Layers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MaxError
        ///</summary>
        [TestMethod()]
        public void MaxErrorTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.MaxError = expected;
            actual = target.MaxError;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OutputUnits
        ///</summary>
        [TestMethod()]
        public void OutputUnitsTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.OutputUnits = expected;
            actual = target.OutputUnits;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SelectedLayer
        ///</summary>
        [TestMethod()]
        public void SelectedLayerTest()
        {
            NeuralNetworksViewModel target = new NeuralNetworksViewModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.SelectedLayer = expected;
            actual = target.SelectedLayer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
