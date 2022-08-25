using TDDCalculator;

namespace TDDCalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(-20, -6, -26)]
        [InlineData(-10, -5, -15)]
        public void Add_AddTwoNegativeInts(int a, int b, int expected)
        {
            //Arrange

            //Act
            var results = Calculator.Add(a, b);

            //Assert
            Assert.Equal(expected, results);

        }

        [Theory]
        [InlineData(-20, -6, -14)]
        [InlineData(-10, -5, -5)]
        [InlineData(100, 50, 50)]
        [InlineData(50, 100, -50)]
        public void Subtract_FindDifferenceFromOneIntToAnother(int a, int b, int expected)
        {
            //Arrange

            //Act
            var results = Calculator.Subtract(a, b);

            //Assert
            Assert.Equal(expected, results);

        }

        [Theory]
        [InlineData(20, 3, 60)]
        //[InlineData(Math.Sqrt(81), 1, 9)]
        [InlineData(9, 3, 27)]

        public void Multiply_FindProductOfTwoInts(int a, int b, int expected)
        {
            //Arrange

            //Act
            var results = Calculator.Multiply(a, b);

            //Assert
            Assert.Equal(expected, results);

        }

        [Theory]
        [InlineData(60, 20, 3)]
        [InlineData(80, 2, 40)]
        [InlineData(9, 0, -999)]

        public void Divide_GivesCorrectQuotientOfTwoInts(int a, int b, int expected)
        {
            //Arrange

            //Act
            var results = Calculator.Divide(a, b);

            //Assert
            Assert.Equal(expected, results);

        }

    }
}