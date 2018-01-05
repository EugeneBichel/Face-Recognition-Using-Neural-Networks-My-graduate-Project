using System;

namespace FaceRecognition.RecognitionMethods.NeuralNetworks.BackPropagation
{
    public class NeuralEventArgs : EventArgs
    {
        public NeuralEventArgs()
        {
            Stop = false;
            CurrentError = 0;
            CurrentIteration = 0;
        }

        public NeuralEventArgs(bool stop, double currError, int currIter)
        {
            Stop = stop;
            CurrentError = currError;
            CurrentIteration = currIter;
        }

        public bool Stop { get; set; }
        public double CurrentError { get; set; }
        public int CurrentIteration { get; set; }
    }
}
