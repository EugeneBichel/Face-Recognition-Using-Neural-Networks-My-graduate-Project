using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using FaceImagesModel;
using FaceRecognition.ViewModel;
using Utility;

namespace FaceRecognition.RecognitionMethods
{
    public class ExtractFeatures : ViewModelBase
    {
        #region Fields

        #endregion //Fields

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

        #region Public Properties



        #endregion //Public Properties

        #region Public Methods

        public void CreateVectors()
        {
            for (var i = 0; i < TrainFaces.Count; i++)
            {
                TrainFaces[i].VectorBeforeFft = ImageToVector(TrainFaces[i].FullName);
            }

            for (var i = 0; i < TestFaces.Count; i++)
            {
                if (TrainFaces.Contains(TestFaces[i]) == false)
                    TestFaces[i].VectorBeforeFft = ImageToVector(TestFaces[i].FullName);
            }
        }

        public void CreateVectors(ObservableCollection<FaceImage> trainFaces, ObservableCollection<FaceImage> testFaces)
        {
            _trainFaces = trainFaces;
            _testFaces = testFaces;

            for (var i = 0; i < _trainFaces.Count; i++)
            {
                _trainFaces[i].VectorBeforeFft = ImageToVector(_trainFaces[i].FullName);
            }

            for (var i = 0; i < _testFaces.Count; i++)
            {
                //if (_testFaces.Contains(_testFaces[i]) == false)
                    _testFaces[i].VectorBeforeFft = ImageToVector(_testFaces[i].FullName);
            }
        }
        
        public void CreateVectorsAfterFFT()
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

        public void SaveTrainTestFaces()
        {
            base.SaveTrainTestFaces();
        }

        #endregion //Public Methods

        #region Fast Fourier Trainformation

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
            alglib.complex[] f = null;

            alglib.fftr1d(vector, out f);

            return f;
        }

        private double[] GetInvFFT(alglib.complex[] dirVector)
        {
            double[] invVector = null;

            alglib.fftr1dinv(dirVector, 200, out invVector);

            return invVector;
        }

        #endregion //Fast Fourier Trainformation

        #region Normalization Vector

        private double[] NormProcess(double[] invVector)
        {
            var minVal = FindMinValue(invVector);
            for (var i = 0; i < invVector.Length; i++)
            {
                invVector[i] -= minVal;
            }

            var maxVal = FindMaxValue(invVector);
            for (var i = 0; i < invVector.Length; i++)
            {
                invVector[i] = (invVector[i] / maxVal) * 65535;
            }
            return invVector;
        }

        #endregion //Normalization Vector

        #region Prepare For Input Nero Net

        private double[] ProcessVectorForInputNet(double[] normVector)
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