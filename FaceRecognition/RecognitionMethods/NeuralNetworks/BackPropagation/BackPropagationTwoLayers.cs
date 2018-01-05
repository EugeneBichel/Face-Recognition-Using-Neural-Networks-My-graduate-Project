using System;
using System.Collections.Generic;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs;

namespace FaceRecognition.NeuralNetworks.BackPropagation
{
    [Serializable]
    class BackPropagationTwoLayers : IBackPropagation
    {
        #region Fields

        private int _inputNum;
        private int _firstHiddenNum;
        private int _outputNum;

        private InputNeuron[] _inputLayer;
        private FirstHiddenNeuron[] _firstHiddenLayer;
        private OutputNeuron[] _outputLayer;

        private double _learningRate;

        #endregion //Fields

        #region Constants

        public BackPropagationTwoLayers(int inputNum, int firstHiddenNum, int outputNum)
        {
            _learningRate = Constants.LEARNING_RATE;

            _inputNum = inputNum;
            _firstHiddenNum = firstHiddenNum;
            _outputNum = outputNum;

            _inputLayer = new InputNeuron[_inputNum];
            _firstHiddenLayer = new FirstHiddenNeuron[_firstHiddenNum];
            _outputLayer = new OutputNeuron[_outputNum];          
        }

        public BackPropagationTwoLayers()
        {
            _learningRate = Constants.LEARNING_RATE;

            _inputNum = 0;
            _firstHiddenNum = 0;
            _outputNum = 0;

            _inputLayer = new InputNeuron[_inputNum];
            _firstHiddenLayer = new FirstHiddenNeuron[_firstHiddenNum];
            _outputLayer = new OutputNeuron[_outputNum]; 
        }

        #endregion //Constants

        #region IBackPropagation Members

        public void BackPropagate()
        {
            double total;

            //Fix Input Layer's Error
            for (var i = 0; i < _firstHiddenNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _outputNum; j++)
                {
                    total += _firstHiddenLayer[i].Weights[j] * _outputLayer[j].Error;
                }
                _firstHiddenLayer[i].Error = total;
            }

            //Update The First Layer's Weights
            for (var i = 0; i < _firstHiddenNum; i++)
            {
                for (var j = 0; j < _inputNum; j++)
                {
                    _inputLayer[j].Weights[i] +=
                        _learningRate * _firstHiddenLayer[i].Error * _inputLayer[j].Value;
                }
            }

            //Update The Second Layer's Weights
            for (var i = 0; i < _outputNum; i++)
            {
                for (var j = 0; j < _firstHiddenNum; j++)
                {
                    _firstHiddenLayer[j].Weights[i] +=
                        _learningRate * _outputLayer[i].Error * _firstHiddenLayer[j].Output;
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

            //Calculate The First(Input) Layer's Inputs and Outputs
            for (var i = 0; i < _firstHiddenNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _inputNum; j++)
                {
                    total += _inputLayer[j].Value * _inputLayer[j].Weights[i];
                }

                _firstHiddenLayer[i].InputSum = total;
                _firstHiddenLayer[i].Output = F(total);
            }

            //Calculate The Second(Output) Layer's Inputs, Outputs, Targets and Errors
            for (var i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _firstHiddenNum; j++)
                {
                    total += _firstHiddenLayer[j].Output * _firstHiddenLayer[j].Weights[i];
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
            for (var j = 0; j < _outputNum; j++)
            {
                total += Math.Pow((_outputLayer[j].Target - _outputLayer[j].output), 2) / 2;
            }
            return total;
        }

        public void InitializeNetwork(List<FaceImage> trainingSet)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Weights = new double[_firstHiddenNum];
                for (j = 0; j < _firstHiddenNum; j++)
                {
                    _inputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            for (i = 0; i < _firstHiddenNum; i++)
            {
                _firstHiddenLayer[i].Weights = new double[_outputNum];
                for (j = 0; j < _outputNum; j++)
                {
                    _firstHiddenLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            int k = 0;
            foreach (FaceImage face in trainingSet)
            {
                _outputLayer[k++].Value = face.PersonId;
            }
        }

        public void Recognize(double[] Input, ref string MatchedHigh, 
            ref double OutputValueHight, ref string MatchedLow, ref double OutputValueLow)
        {
            double total = 0.0;
            double max = -1;

            //Apply input to the network
            for (var i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Value = Input[i];
            }

            //Calculate Input Layer's Inputs and Outputs
            for (var i = 0; i < _firstHiddenNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _inputNum; j++)
                {
                    total += _inputLayer[j].Value * _inputLayer[j].Weights[i];
                }
                _firstHiddenLayer[i].InputSum = total;
                _firstHiddenLayer[i].Output = F(total);
            }

            //Find the [Two] Highest Outputs   
            for (var i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _firstHiddenNum; j++)
                {
                    total += _firstHiddenLayer[j].Output * _firstHiddenLayer[j].Weights[i];
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
