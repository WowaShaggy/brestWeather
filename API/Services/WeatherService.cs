using BrestWeatherRestSharp.Clients;
using BrestWeatherRestSharp.Models.Weather;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BrestWeatherRestSharp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherClient _singleClient;

        public WeatherService(IWeatherClient singleClient)
        {
            _singleClient = singleClient;
        }

        public Response GetCurrentWeather(string q) //Example of using manually added classes in Models directory 
        {
            IRestResponse restResponse = _singleClient.GetCurrentWeather(q);
            Response response = JsonConvert.DeserializeObject<Response>(restResponse.Content);
            return response;
        }

        public JObject GetCurrentWeatherByName(string q) 
        {
            return JObject.Parse(_singleClient.GetCurrentWeather(q).Content);
        }

        public JObject GetCurrentWeatherById(string id)
        {
            return JObject.Parse(_singleClient.GetCurrentWeatherById(id).Content);
        }

        public JObject GetCurrentWeatherById(int id)
        {
            return JObject.Parse(_singleClient.GetCurrentWeatherById(id).Content);
        }
    }
}
