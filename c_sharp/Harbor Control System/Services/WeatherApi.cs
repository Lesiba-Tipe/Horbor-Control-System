using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harbor_Control_System.Services
{
    public class WeatherApi
    {
        public byte cod;
        public string message;
        public City city;
        public List<Forecast> list;

        public class City
        {
            public int id;
            public string country;
            public string name;
            public Coordinates coord;

            public class Coordinates
            {
                public float lon;
                public float lat;
            }

        }


        public class Forecast
        {
            public byte humadity;
            public float pressure;
            public float wind_speed;
            public Temparature temp;

            public class Temparature
            {
                public float average;
                public float averge_min;
                public float average_max;
            }

        }
    }
}
