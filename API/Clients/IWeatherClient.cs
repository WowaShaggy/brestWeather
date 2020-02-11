using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrestWeatherRestSharp.Clients
{
    public interface IWeatherClient
    {
        IRestResponse GetCurrentWeather(string q);

        IRestResponse GetCurrentWeatherById(string id);

        IRestResponse GetCurrentWeatherById(int id);
    }
}
