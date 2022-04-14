using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harbor_Control_System.Entity.Boat
{
    public class Boat
    {
        private List<string> _boatType = new List<string>();

        public string this[int index]
        {
            get { return _boatType[index]; }
            set { _boatType[index] = value; }
        }
    }
}
