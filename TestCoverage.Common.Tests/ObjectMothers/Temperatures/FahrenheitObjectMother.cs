using TestCoverage.Domain.Features.Temperatures;

namespace TestCoverage.Common.Tests.ObjectMothers.Temperatures
{
    public static partial class ObjectMother
    {
        public static class FahrenheitTemperature
        {
            public static Fahrenheit Default
            {
                get
                {
                    return new Fahrenheit()
                    {
                        Temperature = 53.6,
                    };
                }
            }
        }
    }
}
