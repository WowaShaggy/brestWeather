using Autofac;
using BrestWeatherRestSharp.Services;
using NUnit.Framework;

namespace BrestWeatherRestSharp
{
    public abstract class TestBase
    {
        protected ISingleService singleService;

        [SetUp]
        public void Before()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                singleService = scope.Resolve<ISingleService>();
            }
        }
    }
}
