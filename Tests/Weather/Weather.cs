using BrestWeatherRestSharp.Util;
using NUnit.Framework;

namespace BrestWeatherRestSharp.Tests.Weather
{
    [TestFixture]
    public class Weather : TestBase
    {
        [Test]
        public void GetResponseByName()
        {
            string city = "Brest";

            var content = singleService.GetCurrentWeatherByName(city);
            ContentReader cr = new ContentReader(content);

            Assert.That(cr.getId(), Is.EqualTo("629634"), "That is another city's id");
            Assert.That(cr.getMainTemp(), Is.GreaterThan(0), "It's unexpected cold today as for Brest");
        }

        [Test]
        public void GetResponseById()
        {
            int id = 629634;

            var content = singleService.GetCurrentWeatherById(id);
            ContentReader cr = new ContentReader(content);

            Assert.That(cr.getName(), Is.EqualTo("Brest"), "That is another city");
            Assert.That(cr.getMainTemp(), Is.GreaterThan(0), "It's unexpected cold today as for Brest");
        }

        [Test]
        public void GetResponseByIdAsString()
        {
            string id = "629634";

            var content = singleService.GetCurrentWeatherById(id);
            ContentReader cr = new ContentReader(content);

            Assert.That(cr.getName(), Is.EqualTo("Brest"), "That is another city");
            Assert.That(cr.getMainTemp(), Is.GreaterThan(0), "It's unexpected cold today as for Brest");
        }
    }
}
