﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_db_api
{
    public class WeatherForecast
    {
        public string? cod { get; set; }
        public int? message { get; set; }
        public int? cnt { get; set; }
        public City? city { get; set; }
        public IList<WeatherInfo>? list { get; set; }
    }
}
