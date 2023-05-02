using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 5, 5, 20)]
        [InlineData(100, 5, 5, 110)]
        [InlineData(10, -5, 5, 10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var calc = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(100, 5, 95)]
        [InlineData(9, 5, 4)]
        [InlineData(5, 10, -5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:
            
            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 3, 12)]//Add test data <-------
        [InlineData(6, 3, 18)]
        [InlineData(100, 3, 300)]
        [InlineData(16, 3, 48)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 5)]//Add test data <-------
        [InlineData(6, 3, 2)]
        [InlineData(100, 25, 4)]
        [InlineData(16, 4, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Divide(num1, num2);   

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
