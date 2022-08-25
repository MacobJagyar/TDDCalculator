using System;
using TDDCalculator;

namespace TDDCalculatorTests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(10, 5, 50)]
        public void CalculateRectangleArea_CorrectlyReturnsArea(decimal length, decimal width, decimal expected)
        {
            //Arrange

            //Act
            var results = Rectangle.CalculateRectangleArea(length, width);

            //Assert
            Assert.Equal(expected, results);

        }

        [Theory]
        [InlineData(10, 2, 24)]
        [InlineData(10, 5, 30)]
        public void CalculateRectanglePerimeter_CorrectlyReturnsPerimeter(decimal length, decimal width, decimal expected)
        {
            //Arrange

            //Act
            var results = Rectangle.CalculateRectanglePerimeter(length, width);

            //Assert
            Assert.Equal(expected, results);

        }

    }
}

