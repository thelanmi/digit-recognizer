﻿namespace DigitRecognizer.Core.Providers
{
    /// <summary>
    /// Represents a data provider abstraction that a neural network will use for training.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataProvider<out T>
    {
        /// <summary>
        /// Gets the data from a file.
        /// </summary>
        /// <returns></returns>
        T GetData();
    }
}
