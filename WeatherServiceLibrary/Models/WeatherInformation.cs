﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherServiceLibrary.Models
{ 
    public class WeatherInformation
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public string Weather { get; set; }
    }
}
