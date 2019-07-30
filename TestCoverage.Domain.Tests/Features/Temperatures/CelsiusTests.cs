using FluentAssertions;
using NUnit.Framework;
using TestCoverage.Common.Tests.ObjectMothers.Temperatures;

namespace TestCoverage.Domain.Tests.Features.Temperatures
{
    [TestFixture]
    public class CelsiusTests
    {
        [Test]
        public void Celsius_Domain_ConvertToFahrenheit_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInFahrenheit = 53.6;
            var celsius = ObjectMother.CelsiusTemperature.Default;

            //Action
            var result = celsius.ConvertToFahrenheit();

            //Assert
            result.Should().Be(expectedTemperatureInFahrenheit);
        }

        [Test]
        public void Celsius_Domain_ConvertToKelvin_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInKelvin = 285.15;
            var celsius = ObjectMother.CelsiusTemperature.Default;

            //Action
            var result = celsius.ConvertToKelvin();

            //Assert
            result.Should().Be(expectedTemperatureInKelvin);
        }
    }
}
