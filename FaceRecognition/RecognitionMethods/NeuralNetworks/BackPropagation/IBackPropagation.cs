using System;
using System.Collections.Generic;
using FaceImagesModel;

namespace FaceRecognition.NeuralNetworks.BackPropagation
{
    public interface IBackPropagation
    {
        void BackPropagate();
        double F(double x);
        void ForwardPropagate(double[] pattern, string output);
        double GetError();
        void InitializeNetwork(List<FaceImage> trainingSet);
        void Recognize(double[] Input, ref string MatchedHigh, ref double OutputValueHight,
                                        ref string MatchedLow, ref double OutputValueLow);        
    }
}
