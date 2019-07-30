namespace TestCoverage.Domain.Features.Temperatures
{
    public class Celsius
    {
        public double Temperature { get; set; }

        public double ConvertToFahrenheit()
        {
            double result = 1.8 * Temperature + 32;

            return result;
        }

        public double ConvertToKelvin()
        {
            double result = Temperature + 273.15;

            return result;
        }
    }
}
