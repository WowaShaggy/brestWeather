using BrestWeatherRestSharp.Models.Weather;
using FluentAssertions;
using NUnit.Framework;

namespace BrestWeatherRestSharp.Tests.Weather.WithModels
{
    [TestFixture]    //Examples of using manually added classes in Models
    class ModelWeather : TestBase
    {
        [Test] 
        public void GetResponseByName()
        {
            string city = "Brest";

            Response content = singleService.GetCurrentWeather(city);

            content.Name.Should().Be("Brest");
            content.Id.Should().Be(629634);
        }

    }
}
