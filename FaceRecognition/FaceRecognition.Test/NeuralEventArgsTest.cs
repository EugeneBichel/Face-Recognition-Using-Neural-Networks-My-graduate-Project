using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FaceRecognition.Test
{
    
    
    /// <summary>
    ///This is a test class for NeuralEventArgsTest and is intended
    ///to contain all NeuralEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NeuralEventArgsTest
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
        ///A test for NeuralEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralEventArgsConstructorTest()
        {
            bool stop = false; // TODO: Initialize to an appropriate value
            double currError = 0F; // TODO: Initialize to an appropriate value
            int currIter = 0; // TODO: Initialize to an appropriate value
            NeuralEventArgs target = new NeuralEventArgs(stop, currError, currIter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for NeuralEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void NeuralEventArgsConstructorTest1()
        {
            NeuralEventArgs target = new NeuralEventArgs();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CurrentError
        ///</summary>
        [TestMethod()]
        public void CurrentErrorTest()
        {
            NeuralEventArgs target = new NeuralEventArgs(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.CurrentError = expected;
            actual = target.CurrentError;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentIteration
        ///</summary>
        [TestMethod()]
        public void CurrentIterationTest()
        {
            NeuralEventArgs target = new NeuralEventArgs(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.CurrentIteration = expected;
            actual = target.CurrentIteration;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Stop
        ///</summary>
        [TestMethod()]
        public void StopTest()
        {
            NeuralEventArgs target = new NeuralEventArgs(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Stop = expected;
            actual = target.Stop;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
