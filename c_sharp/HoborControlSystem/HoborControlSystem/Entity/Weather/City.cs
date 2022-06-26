using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoborControlSystem.Entity
{
    public class City
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
    }
}
