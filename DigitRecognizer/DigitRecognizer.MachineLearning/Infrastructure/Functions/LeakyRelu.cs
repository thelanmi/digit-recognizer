﻿using DigitRecognizer.Core.Utilities;

namespace DigitRecognizer.MachineLearning.Infrastructure.Functions
{
    /// <summary>
    /// Implements the leaky RELU activation function.
    /// </summary>
    public class LeakyRelu : IActivationFunction
    {
        private const double Alpha = 0.01;

        public string Name => "Leaky Relu";

        /// <summary>
        /// Applies the activation function on every element of the specified array.
        /// </summary>
        /// <param name="arr">The array of values.</param>
        /// <returns>The array with values fed through the activation function.</returns>
        public double[] Activate(double[] arr)
        {
            double[] activations = MathUtilities.LeakyRelu(arr, Alpha);

            return activations;
        }

        /// <summary>
        /// Determines the derivative of the <see cref="LeakyRelu"/> function for the specified inputs.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="oneHot">The one hot encoded element.</param>
        /// <returns>The derivative of the function for every input.</returns>
        public double[] Derivative(double[] input, double[] oneHot)
        {
            var result = new double[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                result[i] = input[i] > 0 ? 1.0 : Alpha;
            }

            return result;
        }
    }
}
