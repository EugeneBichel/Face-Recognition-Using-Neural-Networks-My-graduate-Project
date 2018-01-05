using System;

namespace FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation.Structs
{
    [Serializable]
    struct OutputNeuron
    {
        public double InputSum;
        public double output;
        public double Error;
        public double Target;
        public string Value;
    };
}
