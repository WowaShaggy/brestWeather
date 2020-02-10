using Newtonsoft.Json.Linq;

namespace BrestWeatherRestSharp.Util
{
    public class ContentReader
    {
        private JObject _content;

        public ContentReader(JObject content)
        {
            _content = content;
        }

        public string GetId()
        {
            return _content["id"].ToString();
        }

        public string GetName()
        {
            return _content["name"].ToString();
        }

        public double GetMainTemp()
        {
            return _content["main"]["temp"].ToObject<double>();
        }

    }
}
