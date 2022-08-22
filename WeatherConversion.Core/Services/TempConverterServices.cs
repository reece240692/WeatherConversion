using UTL = UltimateTemperatureLibrary.Converter;


namespace WeatherConversion.Core.Services
{
    public class TempConverterServices
    {
        public string Convert(double temperature, char unitFrom, char unitTo)
        {

            //use UTL and convert accordingly

            if (unitFrom =='F' && unitTo =='C')
            {
                return UTL.Fah2Cel(temperature).ToString("F0");
            }
            if (unitFrom == 'F' && unitTo == 'K')
            {
                return UTL.Fah2Kel(temperature).ToString("F0");               
            }
            if (unitFrom == 'K' && unitTo == 'F')
            {
                return UTL.Kel2Fah(temperature).ToString("F0");
            }
            if (unitFrom == 'K' && unitTo == 'C')
            {
                return UTL.Kel2Cel(temperature).ToString("F0");
            }
            if (unitFrom == 'C' && unitTo == 'F')
            {
                return UTL.Cel2Fah(temperature).ToString("F0");
            }
            if (unitFrom == 'C' && unitTo == 'K')
            {
                return UTL.Cel2Kel(temperature).ToString("F0");
            }
            else //If we got this far, something went wrong!
            return "";

        }

    }
}
