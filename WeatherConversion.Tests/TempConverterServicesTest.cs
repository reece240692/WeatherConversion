

using WeatherConversion.Core.Services;

namespace WeatherConversion.Tests
{
    internal class TempConverterServicesTest
    {
        public readonly TempConverterServices TCS = new();
        //Integration Tests for TCS Library
        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]
        public void Given_Degrees_Centigrade_Service_Should_Return_Correct_Fahrenheit(double temp)
        {
            //Arrange
            var manualCalculation = Convert.ToInt32((temp * 1.8) + 32);
            var result = Convert.ToInt32(TCS.Convert(temp, 'C', 'F'));
            //Act+Assert
            Assert.That(result == manualCalculation);
        }


        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]
        public void Given_Degrees_Fahrenheit_Service_Should_Return_Correct_Celsius(double temp)
        {
            //Arrange
            var manualCalculation = Convert.ToInt32((temp - 32) * 5 / 9);
            var result = Convert.ToInt32(TCS.Convert(temp, 'F', 'C'));
            //Act+Assert
            Assert.That(result == manualCalculation);
        }

        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]
        public void Given_Degrees_Kelvin_Service_Should_Return_Correct_Celsius(double temp)
        {
            //Arrange
            var manualCalculation = Convert.ToInt32((temp - 273.15));
            var result = Convert.ToInt32(TCS.Convert(temp, 'K', 'C'));
            //Act+Assert
            Assert.That(result == manualCalculation);
        }
    }
}
