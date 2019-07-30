using TestCoverage.Domain.Features.Temperatures;

namespace TestCoverage.Common.Tests.ObjectMothers.Temperatures
{
    public static partial class ObjectMother
    {
        public static class KelvinTemperature
        {
            public static Kelvin Default
            {
                get
                {
                    return new Kelvin()
                    {
                        Temperature = 285.15,
                    };
                }
            }
        }
    }
}
