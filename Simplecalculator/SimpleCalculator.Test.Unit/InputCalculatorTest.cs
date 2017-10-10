using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simplecalculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputCalculatorTest
    {

        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertToNumeric(inputNumber);
            
        }
    }
}
