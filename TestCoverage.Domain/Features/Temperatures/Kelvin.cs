namespace TestCoverage.Domain.Features.Temperatures
{
    public class Kelvin
    {
        public double Temperature { get; set; }

        public double ConvertToCelsius()
        {
            double result = Temperature - 273.15;

            return result;
        }

        public double ConvertToFahrenheit()
        {
            double result = (Temperature - 273.15) * 9/5 + 32;

            return result;
        }
    }
}
