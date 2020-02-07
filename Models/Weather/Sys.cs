using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrestWeatherRestSharp.Models.Weather
{
    public class Sys
    {
        public long Type { get; set; }
        public long Id { get; set; }
        public double Message { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}
