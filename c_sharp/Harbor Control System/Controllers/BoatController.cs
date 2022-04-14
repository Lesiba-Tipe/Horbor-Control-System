using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Harbor_Control_System.Services;
using Harbor_Control_System.Entity.Boat;

namespace Harbor_Control_System.Controllers
{
    public class BoatController : Controller
    {
        private BoatService _boatService;

        public BoatController()
        {
            _boatService = new BoatService();

        }
        public List<string> GetBoatType()
        {
            var boatType = _boatService.GetBoatList();

            return boatType;
        }
    }
}
