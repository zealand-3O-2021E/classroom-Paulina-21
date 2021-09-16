using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(-25,3.5)]
        [DataRow(0,30)]
        public void AdditionTest(double a, double b)
        {
            //Arrange
            var cal = new Calculator();
            var actual=cal.Addition(a, b);

            //Act
            double expected = a + b;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(-25, 3.5)]
        [DataRow(0, 30)]
        public void SubtractionTest(double a, double b)
        {
            //Arrange
            var cal = new Calculator();
            var actual = cal.Subtraction(a, b);

            //Act
            double expected = a - b;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(-25, 3.5)]
        [DataRow(0, 30)]
        public void MultiplyTest(double a, double b)
        {
            //Arrange
            var cal = new Calculator();
            var actual = cal.Multiply(a, b);

            //Act
            double expected = a * b;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(-25, 3.5)]
        [DataRow(0, 30)]
        public void DivisionTest(double a, double b)
        {
            //Arrange
            var cal = new Calculator();
            var actual = cal.Division(a, b);

            //Act
            double expected = a/b;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}