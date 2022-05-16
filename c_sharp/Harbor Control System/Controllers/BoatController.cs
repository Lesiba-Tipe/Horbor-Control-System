using Harbor_Control_System.Entity.Boat;
using Harbor_Control_System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Harbor_Control_System.Controllers
{
    public class BoatController : Controller
    {
        private BoatService _boatService;

        public BoatController()
        {
            _boatService = new BoatService();

        }
        public List<Boat> GetBoatType()
        {
            var boatType = _boatService.GetBoatTypeList();

            return boatType;
        }

        public ActionResult SelectedBoat()
        {
            return View(_boatService.GetBoatTypeList());
        }
        [HttpPost]
        public ActionResult SelectedBoat(string data)
        {
            var temp = data;

            ViewBag.lesiba = "Ofenste";// BoatList = _boatService.GetBoatList();
            return View();
        }

        public List<SelectListItem> Boats()
        {
            return null;// new SelectListItem() { }
        }
    }
}
