﻿using FaceRecognition.NeuralNetworks.BackPropagation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FaceImagesModel;
using System.Collections.Generic;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for IBackPropagationTest and is intended
    ///to contain all IBackPropagationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IBackPropagationTest
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


        internal virtual IBackPropagation CreateIBackPropagation()
        {
            // TODO: Instantiate an appropriate concrete class.
            IBackPropagation target = null;
            return target;
        }

        /// <summary>
        ///A test for BackPropagate
        ///</summary>
        [TestMethod()]
        public void BackPropagateTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
            target.BackPropagate();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for F
        ///</summary>
        [TestMethod()]
        public void FTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
            double x = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.F(x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ForwardPropagate
        ///</summary>
        [TestMethod()]
        public void ForwardPropagateTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
            double[] pattern = null; // TODO: Initialize to an appropriate value
            string output = string.Empty; // TODO: Initialize to an appropriate value
            target.ForwardPropagate(pattern, output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetError
        ///</summary>
        [TestMethod()]
        public void GetErrorTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.GetError();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitializeNetwork
        ///</summary>
        [TestMethod()]
        public void InitializeNetworkTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
            List<FaceImage> trainingSet = null; // TODO: Initialize to an appropriate value
            target.InitializeNetwork(trainingSet);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Recognize
        ///</summary>
        [TestMethod()]
        public void RecognizeTest()
        {
            IBackPropagation target = CreateIBackPropagation(); // TODO: Initialize to an appropriate value
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
    }
}
