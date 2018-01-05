using System;
using System.Collections.Generic;
using FaceImagesModel;
using FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs;

namespace FaceRecognition.NeuralNetworks.BackPropagation
{
    [Serializable]
    class BackPropagationThreeLayers : IBackPropagation
    {
        #region Fields

        private int _inputNum;
        private int _firstHiddenNum;
        private int _secondHiddenNum;
        private int _outputNum;

        private InputNeuron[] _inputLayer;
        private FirstHiddenNeuron[] _firstHiddenLayer;
        private SecondHiddenNeuron[] _secondHiddenLayer;
        private OutputNeuron[] _outputLayer;

        private double _learningRate;

        #endregion //Fields

        #region Constructors

        public BackPropagationThreeLayers(int inputNum, int firstHiddenNum, int secondHiddenNum, int outputNum)
        {
            _inputNum = inputNum;
            _firstHiddenNum = firstHiddenNum;
            _secondHiddenNum = secondHiddenNum;
            _outputNum = outputNum;

            _inputLayer = new InputNeuron[_inputNum];
            _firstHiddenLayer = new FirstHiddenNeuron[_firstHiddenNum];
            _secondHiddenLayer = new SecondHiddenNeuron[_secondHiddenNum];
            _outputLayer = new OutputNeuron[_outputNum];          
        }

        public BackPropagationThreeLayers()
        {
            _inputNum = 0;
            _firstHiddenNum = 0;
            _secondHiddenNum = 0;
            _outputNum = 0;

            _inputLayer = new InputNeuron[_inputNum];
            _firstHiddenLayer = new FirstHiddenNeuron[_firstHiddenNum];
            _secondHiddenLayer = new SecondHiddenNeuron[_secondHiddenNum];
            _outputLayer = new OutputNeuron[_outputNum]; 
        }

        #endregion //Constructors

        #region IBackPropagation Members

        public void BackPropagate()
        {
            int i, j;
            double total;

            //Fix Hidden Layer's Error
            for (i = 0; i < _secondHiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < _outputNum; j++)
                {
                    total += _secondHiddenLayer[i].Weights[j] * _outputLayer[j].Error;
                }
                _secondHiddenLayer[i].Error = total;
            }

            //Fix Input Layer's Error
            for (i = 0; i < _firstHiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < _secondHiddenNum; j++)
                {
                    total += _firstHiddenLayer[i].Weights[j] * _secondHiddenLayer[j].Error;
                }
                _firstHiddenLayer[i].Error = total;
            }

            //Update The First Layer's Weights
            for (i = 0; i < _firstHiddenNum; i++)
            {
                for (j = 0; j < _inputNum; j++)
                {
                    _inputLayer[j].Weights[i] +=
                        _learningRate * _firstHiddenLayer[i].Error * _inputLayer[j].Value;
                }
            }

            //Update The Second Layer's Weights
            for (i = 0; i < _secondHiddenNum; i++)
            {
                for (j = 0; j < _firstHiddenNum; j++)
                {
                    _firstHiddenLayer[j].Weights[i] +=
                        Constants.LEARNING_RATE * _secondHiddenLayer[i].Error * _firstHiddenLayer[j].Output;
                }
            }

            //Update The Third Layer's Weights
            for (i = 0; i < _outputNum; i++)
            {
                for (j = 0; j < _secondHiddenNum; j++)
                {
                    _secondHiddenLayer[j].Weights[i] +=
                        _learningRate * _outputLayer[i].Error * _secondHiddenLayer[j].Output;
                }
            }
        }

        public double F(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        public void ForwardPropagate(double[] pattern, string output)
        {
            int i, j;
            double total;

            //Apply input to the network
            for (i = 0; i < _inputNum; i++)
            {
                _inputLayer[i].Value = pattern[i];
            }

            //Calculate The First(Input) Layer's Inputs and Outputs
            for (i = 0; i < _firstHiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < _inputNum; j++)
                {
                    total += _inputLayer[j].Value * _inputLayer[j].Weights[i];
                }
                _firstHiddenLayer[i].InputSum = total;
                _firstHiddenLayer[i].Output = F(total);
            }

            //Calculate The Second(Hidden) Layer's Inputs and Outputs
            for (i = 0; i < _secondHiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < _firstHiddenNum; j++)
                {
                    total += _firstHiddenLayer[j].Output * _firstHiddenLayer[j].Weights[i];
                }

                _secondHiddenLayer[i].InputSum = total;
                _secondHiddenLayer[i].Output = F(total);
            }

            //Calculate The Third(Output) Layer's Inputs, Outputs, Targets and Errors
            for (i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < _secondHiddenNum; j++)
                {
                    total += _secondHiddenLayer[j].Output * _secondHiddenLayer[j].Weights[i];
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
                _inputLayer[i].Weights = new double[_firstHiddenNum];
                for (var j = 0; j < _firstHiddenNum; j++)
                {
                    _inputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
                }
            }

            for (var i = 0; i < _firstHiddenNum; i++)
            {
                _firstHiddenLayer[i].Weights = new double[_secondHiddenNum];
                for (var j = 0; j < _secondHiddenNum; j++)
                {
                    _firstHiddenLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
                }
            }

            for (var i = 0; i < _secondHiddenNum; i++)
            {
                _secondHiddenLayer[i].Weights = new double[_outputNum];
                for (var j = 0; j < _outputNum; j++)
                {
                    _secondHiddenLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
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

            //Calculate Hidden Layer's Inputs and Outputs
            for (var i = 0; i < _secondHiddenNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _firstHiddenNum; j++)
                {
                    total += _firstHiddenLayer[j].Output * _firstHiddenLayer[j].Weights[i];
                }

                _secondHiddenLayer[i].InputSum = total;
                _secondHiddenLayer[i].Output = F(total);
            }

            //Find the [Two] Highest Outputs
            for (var i = 0; i < _outputNum; i++)
            {
                total = 0.0;
                for (var j = 0; j < _secondHiddenNum; j++)
                {
                    total += _secondHiddenLayer[j].Output * _secondHiddenLayer[j].Weights[i];
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
