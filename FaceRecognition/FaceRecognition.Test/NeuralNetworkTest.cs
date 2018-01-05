using FaceRecognition.NeuralNetworks.BackPropagation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceImagesModel;
using System.Collections.Generic;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for NeuralNetworkTest and is intended
    ///to contain all NeuralNetworkTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NeuralNetworkTest
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
        ///A test for NeuralNetwork`1 Constructor
        ///</summary>
        public void NeuralNetworkConstructorTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void NeuralNetworkConstructorTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call NeuralNetworkConstructorTestHelper<T>() with appropriate type parame" +
                    "ters.");
        }

        /// <summary>
        ///A test for NeuralNetwork`1 Constructor
        ///</summary>
        public void NeuralNetworkConstructorTest1Helper<T>()
            where T : IComparable<T>
        {
            IBackPropagation IBackPro = null; // TODO: Initialize to an appropriate value
            List<FaceImage> trainingSet = null; // TODO: Initialize to an appropriate value
            NeuralNetwork<T> target = new NeuralNetwork<T>(IBackPro, trainingSet);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void NeuralNetworkConstructorTest1()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call NeuralNetworkConstructorTest1Helper<T>() with appropriate type param" +
                    "eters.");
        }

        /// <summary>
        ///A test for LoadNetwork
        ///</summary>
        public void LoadNetworkTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.LoadNetwork(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void LoadNetworkTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call LoadNetworkTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for Recognize
        ///</summary>
        public void RecognizeTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            double[] Input = null; // TODO: Initialize to an appropriate value
            string MatchedHigh = string.Empty; // TODO: Initialize to an appropriate value
            string MatchedHighExpected = string.Empty; // TODO: Initialize to an appropriate value
            double OutputValueHight = 0F; // TODO: Initialize to an appropriate value
            double OutputValueHightExpected = 0F; // TODO: Initialize to an appropriate value
            string MatchedLow = string.Empty; // TODO: Initialize to an appropriate value
            string MatchedLowExpected = string.Empty; // TODO: Initialize to an appropriate value
            double OutputValueLow = 0F; // TODO: Initialize to an appropriate value
            double OutputValueLowExpected = 0F; // TODO: Initialize to an appropriate value
            target.Recognize(Input, ref MatchedHigh, ref OutputValueHight, ref MatchedLow, ref OutputValueLow);
            Assert.AreEqual(MatchedHighExpected, MatchedHigh);
            Assert.AreEqual(OutputValueHightExpected, OutputValueHight);
            Assert.AreEqual(MatchedLowExpected, MatchedLow);
            Assert.AreEqual(OutputValueLowExpected, OutputValueLow);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void RecognizeTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call RecognizeTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for SaveNetwork
        ///</summary>
        public void SaveNetworkTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.SaveNetwork(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void SaveNetworkTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call SaveNetworkTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for Train
        ///</summary>
        public void TrainTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Train();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TrainTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call TrainTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for MaximumError
        ///</summary>
        public void MaximumErrorTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.MaximumError = expected;
            actual = target.MaximumError;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MaximumErrorTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call MaximumErrorTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for MaximumIteration
        ///</summary>
        public void MaximumIterationTestHelper<T>()
            where T : IComparable<T>
        {
            NeuralNetwork<T> target = new NeuralNetwork<T>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.MaximumIteration = expected;
            actual = target.MaximumIteration;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MaximumIterationTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call MaximumIterationTestHelper<T>() with appropriate type parameters.");
        }
    }
}
