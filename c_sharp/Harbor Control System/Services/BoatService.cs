using System.Collections.Generic;

namespace Harbor_Control_System.Services
{
    public class BoatService
    {
        
        public List<string> GetBoatList()
        {
            var boardTypes = new List<string>() { "Speed board", "Cargo ship", "Sailboard" };

            return boardTypes;
        }
    }
}
