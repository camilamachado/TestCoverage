namespace TestCoverage.Domain.Features.Temperatures
{
    public class Fahrenheit
    {
        public double Temperature { get; set; }

        public double ConvertToCelsius()
        {
            double result = (Temperature - 32) * 5/9;

            return result;
        }

        public double ConvertToKelvin()
        {
            double result = ((Temperature - 32) / 1.8) + 273.15;

            return result;
        }
    }
}
