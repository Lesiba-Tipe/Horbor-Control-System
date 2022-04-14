﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harbor_Control_System.Entity
{
    public class Weather
    {
        public byte StatusCode { get; set; }
        public string Message { get; set; }
        public City City { get; set; }
        public List<Forecast> Forecast { get; set; }
    }
}
