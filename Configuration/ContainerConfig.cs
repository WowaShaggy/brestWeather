using Autofac;
using BrestWeatherRestSharp.Clients;
using BrestWeatherRestSharp.Services;
using BrestWeatherRestSharp.util;
using BrestWeatherRestSharp.Util;
using RestSharp;
using System.Configuration;

namespace BrestWeatherRestSharp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(BuildRestClient()).As<IRestClient>().Keyed<IRestClient>("weather"); ;
            builder.Register(ctx => new WeatherClient(ctx.ResolveKeyed<IRestClient>("weather"), Constants.Weather))
                .As<IWeatherClient>();
            builder.RegisterType<WeatherService>().As<IWeatherService>();

            return builder.Build();
        }

        private static IRestClient BuildRestClient()
        {
            string url = ConfigurationManager.AppSettings["OpenWeatherMapUrl"];
            string appId = ConfigurationManager.AppSettings["AppId"];
            IRestClient restClient = new RestClient(url);
            restClient.AddDefaultParameter(QueryConstants.ApiKey, appId);
            return restClient;
        }

    }
}
