using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Tests
{
    public class CalculationTests
    {
        [Theory]
        [InlineData(4,6,10)]
        [InlineData(0,0,0)]
        [InlineData(-4,-6,-10)]
        [InlineData(4,-6,-2)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8,2,6)]
        [InlineData(0,0,0)]
        [InlineData(-5,-5,0)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Subtract(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(40,0,0)]
        [InlineData(-10,3,-30)]
        [InlineData(-10,-3,30)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Multiply(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0,1,0)]
        [InlineData(5,1,5)]
        [InlineData(0, -5, 0)]
        [InlineData(0, 0, 1)]

        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Divide(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
