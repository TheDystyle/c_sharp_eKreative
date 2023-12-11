using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_db_api
{
    public class WeatherInfo
    {
        public int? dt { get; set; }
        public WeatherInfoMain? main { get; set; }
        public IList<WeatherInfoWeatherItem>? weather { get; set; }
        public WeatherInfoWind? wind { get; set; }
        public string? dt_txt { get; set; }

    }
}
