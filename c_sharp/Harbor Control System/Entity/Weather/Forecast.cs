using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harbor_Control_System.Entity
{
    public class Forecast
    {
        public byte Humadity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public Temperature Temperature { get; set; }
    }
}
