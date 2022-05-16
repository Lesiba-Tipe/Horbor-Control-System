using Harbor_Control_System.Entity.Boat;
using System.Collections.Generic;

namespace Harbor_Control_System.Services
{
    public class BoatService
    {

        public List<Boat> GetBoatTypeList()
        {
            var boardTypes = new List<Boat>()
            {
                new Boat()
                {
                    BoatType = "Speed board",
                    Name = "Figo Interntional"
                },
                new Boat(){ BoatType = "Cargo ship" },
                new Boat(){ BoatType = "Sailboard" },
            };

            return boardTypes;
        }

        public List<Boat> Boats()
        {
            var _boats = new List<Boat>() { };
            return _boats;
        }
    }
}
