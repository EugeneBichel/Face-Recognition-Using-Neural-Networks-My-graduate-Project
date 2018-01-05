using System;

namespace FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs
{
    [Serializable]
    struct FirstHiddenNeuron
    {
        public double InputSum;
        public double Output;
        public double Error;
        public double[] Weights;
    };
}
