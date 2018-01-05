using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.ViewModel;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Utility;

namespace FaceRecognition.RecognitionMethods.NeuralNetworks
{
    public class ExtractFeatures : ViewModelBase
    {
        #region Constructor

        public ExtractFeatures()
        {
            
        }
        public ExtractFeatures(ObservableCollection<FaceImage> trainFaces, ObservableCollection<FaceImage> testFaces)
        {
            _trainFaces = trainFaces;
            _testFaces = testFaces;
        }

        #endregion //Constructor

        #region Public Methods

        public void CreateVectors()
        {
            try
            {
                for (var i = 0; i < TrainFaces.Count; i++)
                    TrainFaces[i].VectorBeforeFft = ImageToVector(TrainFaces[i].FullName);

                for (var i = 0; i < TestFaces.Count; i++)
                    if (TrainFaces.Contains(TestFaces[i]) == false)
                        TestFaces[i].VectorBeforeFft = ImageToVector(TestFaces[i].FullName);
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed convert image to vector");
            }
        }

        public void CreateVectors(ObservableCollection<FaceImage> trainFaces, ObservableCollection<FaceImage> testFaces)
        {
            if (trainFaces == null)
                throw new ArgumentNullException("trainFaces");
            if (testFaces == null)
                throw new ArgumentNullException("testFaces");

            _trainFaces = trainFaces;
            _testFaces = testFaces;

            try
            {
                for (var i = 0; i < _trainFaces.Count; i++)
                    _trainFaces[i].VectorBeforeFft = ImageToVector(_trainFaces[i].FullName);

                for (var i = 0; i < _testFaces.Count; i++)
                {
                    //if (_testFaces.Contains(_testFaces[i]) == false)
                    _testFaces[i].VectorBeforeFft = ImageToVector(_testFaces[i].FullName);
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed convert image to vector");
            }
        }
        
        public void CreateVectorsAfterFFT()
        {
            try
            {
                for (var i = 0; i < _trainFaces.Count; i++)
                {
                    alglib.complex[] vector = GetDirectFFT(_trainFaces[i].VectorBeforeFft);
                    double[] invVector = GetInvFFT(vector);
                    double[] normVector = NormProcess(invVector);
                    _trainFaces[i].VectorAfterFft = normVector;

                    double[] inputVector = ProcessVectorForInputNet(normVector);
                    _trainFaces[i].VectorInNet = inputVector;
                }

                for (var i = 0; i < _testFaces.Count; i++)
                {
                    if (_trainFaces.Contains(_testFaces[i]) == false)
                    {
                        alglib.complex[] vector = GetDirectFFT(_testFaces[i].VectorBeforeFft);
                        double[] invVector = GetInvFFT(vector);

                        double[] normVector = NormProcess(invVector);
                        _testFaces[i].VectorAfterFft = normVector;

                        double[] inputVector = ProcessVectorForInputNet(normVector);
                        _testFaces[i].VectorInNet = inputVector;
                    }
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed process vector aftet fft");
            }
        }

        public void SaveTrainTestFaces()
        {
            SaveTrainFaces();
            SaveTestFaces();
        }

        #endregion //Public Methods

        #region Fast Fourier Transformation

        private double[] ImageToVector(string fullNameImage)
        {
            if (Helper.IsStringMissing(fullNameImage) == true)
                throw new ArgumentException("fullNameImage");

            if (File.Exists(fullNameImage) == false)
                throw new FileNotFoundException(fullNameImage);

            var image = new Bitmap(fullNameImage);
            if (image == null)
                throw new InvalidOperationException("image");

            var dwSize = image.Width * image.Height;

            var vector = new double[dwSize];

            for (var i = 0; i < image.Height; i++)
            {
                for (var j = 0; j < image.Width; j++)
                {
                    vector[i * image.Width + j] = image.GetPixel(j, i).ToArgb();
                }
            }

            return vector;
        }

        private alglib.complex[] GetDirectFFT(double[] vector)
        {
            try
            {
                alglib.complex[] f = null;

                alglib.fftr1d(vector, out f);

                return f;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed direct fft");
            }
            return null;
        }

        private double[] GetInvFFT(alglib.complex[] dirVector)
        {
            try
            {
                double[] invVector = null;
                alglib.fftr1dinv(dirVector, Constants.NUMBER_COEFF_FOURIER, out invVector);

                return invVector;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed inverse fft");
            }

            return null;
        }

        #endregion //Fast Fourier Trainformation

        #region Normalization Vector

        private double[] NormProcess(double[] invVector)
        {
            if (invVector == null)
                throw new ArgumentNullException("invVector");

            try
            {
                var minVal = FindMinValue(invVector);
                for (var i = 0; i < invVector.Length; i++)
                    invVector[i] -= minVal;

                var maxVal = FindMaxValue(invVector);
                for (var i = 0; i < invVector.Length; i++)
                    invVector[i] = (invVector[i] / maxVal) * Constants.MAX_SIXTEENBITS_NUMBER;
                return invVector;
            }
            catch(Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed process for normalization vector");
            }
                return null;
        }

        #endregion //Normalization Vector

        #region Prepare For Input Nero Net

        private double[] ProcessVectorForInputNet(double[] normVector)
        {
            if (normVector == null)
                throw new ArgumentNullException("normVector");

            try
            {
                var t = -1;
                var inputVector = new double[normVector.Length];
                var min = FindMinValue(normVector);
                var max = FindMaxValue(normVector);
                var range = max - min;
                if (range == 0)
                    range = 1;

                for (var i = 0; i < normVector.Length; i++)
                {
                    if (normVector[i] - min != 0)
                        inputVector[i] = (1 / (range * (normVector[i] - min))) + t;
                    else
                        inputVector[i] = 0;
                }

                return inputVector;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed process vector for neuron net");
            }

            return null;
        }

        private double[] ReverseProcessVectorFromOutNet(double[] outVector)
        {
            var t = -1;
            var outputVector = new double[outVector.Length];
            var min = FindMinValue(outVector);
            var max = FindMaxValue(outVector);
            var range = max - min;
            if (range == 0)
                range = 1;

            for (var i = 0; i < outVector.Length; i++)
            {
                if (outVector[i] - min != 0)
                    outputVector[i] = (range / (1 * (outVector[i] - t))) + min;
                else
                    outputVector[i] = 0;
            }

            return outputVector;
        }

        #endregion //Prepare For Input Nero Net

        #region Helper Methods

        private double FindMinValue(double[] vector)
        {
            if (vector == null)
                throw new ArgumentNullException("vector");

            var minVal = vector[0];

            for (var i = 1; i < vector.Length; i++)
            {
                if (minVal > vector[i])
                    minVal = vector[i];
            }

            return minVal;
        }

        private double FindMaxValue(double[] vector)
        {
            if (vector == null)
                throw new ArgumentNullException("vector");

            var maxVal = vector[0];

            for (var i = 1; i < vector.Length; i++)
            {
                if (maxVal < vector[i])
                    maxVal = vector[i];
            }

            return maxVal;
        }

        #endregion //Helper Methods
    }
}