using FluentAssertions;
using NUnit.Framework;
using TestCoverage.Common.Tests.ObjectMothers.Temperatures;

namespace TestCoverage.Domain.Tests.Features.Temperatures
{
    [TestFixture]
    public class KelvinTests
    {
        [Test]
        public void Kelvin_Domain_ConvertToCelsius_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInCelsius = 12;
            var celsius = ObjectMother.KelvinTemperature.Default;

            //Action
            var result = celsius.ConvertToCelsius();

            //Assert
            result.Should().Be(expectedTemperatureInCelsius);
        }

        [Test]
        public void Kelvin_Domain_ConvertToFahrenheit_ShouldBeOk()
        {
            //Arrange
            var expectedTemperatureInFahrenheit = 53.6;
            var celsius = ObjectMother.KelvinTemperature.Default;

            //Action
            var result = celsius.ConvertToFahrenheit();

            //Assert
            result.Should().Be(expectedTemperatureInFahrenheit);
        }
    }
}
