using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrestWeatherRestSharp.Models.Weather
{
    public class Main
    {
        public double Temp { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
    }
}
