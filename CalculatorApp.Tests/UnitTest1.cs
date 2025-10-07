
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrage
            var calc = new Calculator();

            //Act
            var result = calc.Add(2, 3);

            //Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var calc = new Calculator();
            var result = calc.Subtract(5, 2);
            Assert.Equal(3, result);
        }
    }
}