﻿using DigitRecognizer.Core.Utilities;
using DigitRecognizer.MachineLearning.Interfaces.Functions;

namespace DigitRecognizer.MachineLearning.Functions
{
    public class CrossEntropy : ILossFunction
    {
        public string Name => "Cross Entropy";

        public double Loss(double[] estimatedValues, double[] actualValues)
        {
            return MathUtilities.CrossEntropy(estimatedValues, actualValues);
        }

        public double Derivative(double[] input, int current, int oneHot)
        {
            var result = 1.0 / (input[oneHot] + double.Epsilon);

            return result;
        }
    }
}