using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs;

namespace FaceRecognition.NeuralNetworks.BackPropagation
{
    [Serializable]
    class BackPropagationOneLayer : IBackPropagation
    {
        private int _inputNum;
        private int _outputNum;

        private InputNeuron[] _inputLayer;
        private OutputNeuron[] _outputLayer;

        private double _learningRate;

        public BackPropagationOneLayer(int inputNum, int outputNum)
        {
            _learningRate = Constants.LEARNING_RATE;

            _inputNum = inputNum;
            _outputNum = outputNum;

            _inputLayer = new InputNeuron[_inputNum];
            _outputLayer = new OutputNeuron[_outputNum];
        }

        public BackPropagationOneLayer()
        {
            _learningRate = Constants.LEARNING_RATE;

            _inputNum = 0;
            _outputNum = 0;

            _inputLayer = new InputNeuron[_inputNum];
            _outputLayer = new OutputNeuron[_outputNum];
        }

        #region IBackPropagation Members

        public void BackPropagate()
        {
            //Update The First Layer's Weights
            for (var j = 0; j < _outputNum; j++)
            {
                for (var i = 0; i < _inputNum; i++)
                {
                    _inputLayer[i].Weights[j] += LearningRate * (_outputLayer[j].Error) * _inputLayer[i].Value;
                }
            }
        }

        public double F(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        public void ForwardPropagate(double[] pattern, string output)
        {
            double total = 0.0;

            //Apply input to the network
            for (var i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Value = pattern[i];
            }

            //Calculate The First(Output) Layer's Inputs, Outputs, Targets and Errors
            for (var i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _inputNum; j++)
                {
                    total += _inputLayer[j].Value * _inputLayer[j].Weights[i];
                }
                _outputLayer[i].InputSum = total;
                _outputLayer[i].output = F(total);
                _outputLayer[i].Target = _outputLayer[i].Value.CompareTo(output) == 0 ? 1.0 : 0.0;
                _outputLayer[i].Error = (_outputLayer[i].Target - _outputLayer[i].output) * (_outputLayer[i].output) * (1 - _outputLayer[i].output);
            }
        }

        public double GetError()
        {
            double total = 0.0;
            for (int j = 0; j < _outputNum; j++)
            {
                total += Math.Pow((_outputLayer[j].Target - _outputLayer[j].output), 2) / 2;
            }
            return total;
        }

        public void InitializeNetwork(List<FaceImage> trainingSet)
        {
            Random rand = new Random();
            for (var i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Weights = new double[_outputNum];
                for (var j = 0; j < _outputNum; j++)
                {
                    _inputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 2) / 100);
                }
            }

            int k = 0;
            foreach (FaceImage face in trainingSet)
            {
                _outputLayer[k++].Value = face.PersonId;
            }
        }

        public void Recognize(double[] Input, ref string MatchedHigh, ref double OutputValueHight,
            ref string MatchedLow, ref double OutputValueLow)
        {
            double total = 0.0;
            double max = -1;

            //Apply Input to Network
            for (var i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Value = Input[i];
            }

            //Find the [Two] Highest Outputs
            for (var i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _inputNum; j++)
                {
                    total += _inputLayer[j].Value * _inputLayer[j].Weights[i];
                }
                _outputLayer[i].InputSum = total;
                _outputLayer[i].output = F(total);
                if (_outputLayer[i].output > max)
                {
                    MatchedLow = MatchedHigh;
                    OutputValueLow = max;
                    max = _outputLayer[i].output;
                    MatchedHigh = _outputLayer[i].Value;
                    OutputValueHight = max;
                }
            }
        }

        #endregion

        public double LearningRate
        {
            get { return _learningRate; }
            set { _learningRate = value; }
        }

    }
}
