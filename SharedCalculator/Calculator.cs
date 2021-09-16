using System;

namespace SharedCalculator
{
    /// <summary>
    /// This is the Calculator with its methods
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two variables (a,b)
        /// </summary>
        /// <param name="a">first variable (double)</param>
        /// <param name="b">second variable (double)</param>
        /// <returns></returns>
        public double Addition(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtracts variable 'a' from 'b'
        /// </summary>
        /// <param name="a">first variable (double)</param>
        /// <param name="b">second variable (double)</param>
        /// <returns></returns>
        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two variables (a,b)
        /// </summary>
        /// <param name="a">first variable (double)</param>
        /// <param name="b">second variable (double)</param>
        /// <returns></returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides variable b from a
        /// </summary>
        /// <param name="a">first variable (double)</param>
        /// <param name="b">second variable (double)</param>
        /// <returns></returns>
        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}
