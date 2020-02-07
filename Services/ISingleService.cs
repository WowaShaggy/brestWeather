﻿using BrestWeatherRestSharp.Models.Weather;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BrestWeatherRestSharp.Services
{
    public interface ISingleService
    {
        Response GetCurrentWeather(string q); //parameter Response is used to access manually added classes in Models directory

        JObject GetCurrentWeatherByName(string q);

        JObject GetCurrentWeatherById(string id);

        JObject GetCurrentWeatherById(int id);
    }
}
