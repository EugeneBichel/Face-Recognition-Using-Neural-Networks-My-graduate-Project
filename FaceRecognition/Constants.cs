using System.Collections.Generic;

namespace FaceRecognition
{
    public class Constants
    {
        public static readonly int MAX_SIXTEENBITS_NUMBER = 65535;

        public static readonly double LEARNING_RATE = 0.1;
        public static readonly double MAX_ERROR = 1.0;
        public static readonly int MAX_ITERATION = 10000;

        public static readonly int EIGEN_FACE = 0;

        public static readonly int ONE_LAYER_BACK_PROPAGATION = 1;
        public static readonly int TWO_LAYER_BACK_PROPAGATION = 2;
        public static readonly int THREE_LAYER_BACK_PROPAGATION = 3;

        public static readonly int NUMBER_COEFF_FOURIER = 200;

        public static readonly int SUCCESS = 4;
        public static readonly int FAILED = 5;

        public static readonly List<string> TrainAndTestViewProperties = new List<string>() { "TrainImages", "TestImages" };
        public static readonly List<string> RecognitionMethodsViewProperties = new List<string>() { "SelectedMethods" };
    }
}
