using FluentAssertions;
using NUnit.Framework;
using TestCoverage.Common.Tests.ObjectMothers.Temperatures;

namespace TestCoverage.Domain.Tests.Features.Temperatures
{
    [TestFixture]
    public class FahrenheitTests
    {
        [Test]
        public void Fahrenheit_Domain_ConvertToCelsius_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInCelsius = 12;
            var celsius = ObjectMother.FahrenheitTemperature.Default;

            //Action
            var result = celsius.ConvertToCelsius();

            //Assert
            result.Should().Be(expectedTemperatureInCelsius);
        }

        [Test]
        public void Fahrenheit_Domain_ConvertToKelvin_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInKelvin = 285.15;
            var celsius = ObjectMother.FahrenheitTemperature.Default;

            //Action
            var result = celsius.ConvertToKelvin();

            //Assert
            result.Should().Be(expectedTemperatureInKelvin);
        }
    }
}
