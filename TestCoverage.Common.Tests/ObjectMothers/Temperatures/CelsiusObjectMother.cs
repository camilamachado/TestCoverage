using TestCoverage.Domain.Features.Temperatures;

namespace TestCoverage.Common.Tests.ObjectMothers.Temperatures
{
    public static partial class ObjectMother
    {
        public static class CelsiusTemperature
        {
            public static Celsius Default
            {
                get
                {
                    return new Celsius()
                    {
                        Temperature = 12,
                    };
                }
            }
        }

    }
}
