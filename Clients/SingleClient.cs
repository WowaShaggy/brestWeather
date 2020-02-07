using BrestWeatherRestSharp.util;
using BrestWeatherRestSharp.Util;
using RestSharp;

namespace BrestWeatherRestSharp.Clients
{
    public class SingleClient : ISingleClient
    {
        private readonly IRestClient _restClient;
        private readonly string _data;
        private readonly double _version;
        private readonly string _operation;
        private readonly string _path;

        public SingleClient(IRestClient restClient, string operation, string data = Constants.Data, double version = Constants.Version)
        {
            _restClient = restClient;
            _data = data;
            _version = version;
            _operation = operation;
            _path = $"{_data}/{_version}/{_operation}";
        }

        public IRestResponse GetCurrentWeather(string q)
        {
            var request = new RestRequest(_path, DataFormat.Json);
            request.AddParameter(QueryConstants.CityName, q);
            IRestResponse response = _restClient.Get(request);
            return response;
        }

        public IRestResponse GetCurrentWeatherById(string id)
        {
            var request = new RestRequest(_path, DataFormat.Json);
            request.AddParameter(QueryConstants.Id, id);
            IRestResponse response = _restClient.Get(request);
            return response;
        }

        public IRestResponse GetCurrentWeatherById(int id)
        {
            var request = new RestRequest(_path, DataFormat.Json);
            request.AddParameter(QueryConstants.Id, id);
            IRestResponse response = _restClient.Get(request);
            return response;
        }
    }
}
