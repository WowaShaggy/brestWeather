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

        public string getId()
        {
            return _content["id"].ToString();
        }

        public string getName()
        {
            return _content["name"].ToString();
        }

        public double getMainTemp()
        {
            return _content["main"]["temp"].ToObject<double>();
        }

    }
}
