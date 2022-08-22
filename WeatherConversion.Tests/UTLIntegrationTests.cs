using UTL = UltimateTemperatureLibrary.Converter;

namespace WeatherConversion.Tests
{
    public class Tests
    {
        
        //Integration Tests for UTL Library
        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]      
        public void Given_Degrees_Centigrade_Library_Should_Return_Correct_Fahrenheit(double temp)
        {
            //Arrange
            
            var manualCalculation = Convert.ToInt32((temp * 1.8) + 32);
           var result = Convert.ToInt32(UTL.Cel2Fah(temp));
            //Act+Assert
            Assert.That(result ==manualCalculation);
        }

     
        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]
        public void Given_Degrees_Fahrenheit_Library_Should_Return_Correct_Celsius(double temp)
        {
            //Arrange
            var manualCalculation = Convert.ToInt32((temp - 32) *5/9);
            var result = Convert.ToInt32(UTL.Fah2Cel(temp));
            //Act+Assert
            Assert.That(result == manualCalculation);
        }

        [TestCase(30.1)]
        [TestCase(-5)]
        [TestCase(1.4)]
        [TestCase(1.450123456)]
        public void Given_Degrees_Kelvin_Library_Should_Return_Correct_Celsius(double temp)
        {
            //Arrange
            var manualCalculation = Convert.ToInt32((temp - 273.15));
            var result = Convert.ToInt32(UTL.Kel2Cel(temp));
            //Act+Assert
            Assert.That(result == manualCalculation);
        }
    }
   
}