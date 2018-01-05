using System;

namespace FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs
{
    [Serializable]
    struct InputNeuron
    {
        public double Value;
        public double[] Weights;
    };
}
