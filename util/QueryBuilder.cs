using BrestWeatherRestSharp.util;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrestWeatherRestSharp
{
    public class QueryBuilder : TestBase
    {
        RestRequest request;
        RestClient client;

        public QueryBuilder(string url = BaseUrl, string apiKey = ApiKey, string data = Data, double version = Version)
        {
            client = new RestClient(url);
            request = new RestRequest($"{data}/{version}/"+ "{segment}", Method.GET);
            request.AddParameter(QueryConstants.ApiKey, apiKey);
        }

        public QueryBuilder withOperation(string operation)
        {
            request.AddUrlSegment("segment", operation);
            return this;
        }

        public QueryBuilder withUnits(string units)
        {
            request.AddParameter(QueryConstants.Units, units);
            return this;
        }

        public QueryBuilder byId(int id)
        {
            request.AddParameter(QueryConstants.Id, id);
            return this;
        }

        public QueryBuilder byId(string id)
        {
            request.AddParameter(QueryConstants.Id, id);
            return this;
        }

        public QueryBuilder byCityName(string cityName)
        {
            request.AddParameter(QueryConstants.CityName, cityName);
            return this;
        }

        public string ExecuteContent()
        {
           return client.Execute(request).Content;
        }

        public IRestResponse ExecuteResponse()
        {
            return client.Execute(request);
        }
    }
}
