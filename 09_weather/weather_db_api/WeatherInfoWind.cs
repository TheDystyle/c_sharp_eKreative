﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_db_api
{
    public class WeatherInfoWind
    {
        public double? speed { get; set; }
        public int? deg { get; set; }
        public double? gust { get; set; }
    }
}