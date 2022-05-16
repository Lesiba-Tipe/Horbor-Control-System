
using Harbor_Control_System.Controllers;
using Harbor_Control_System.Entity;
using Harbor_Control_System.Entity.Boat;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Harbor_Control_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Boat> _boatTypeList = new List<Boat>();
        public Weather _weather;
        public string _currentStatus;

        public string BoatType { get; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var _boatController = new BoatController();
            var _weatherContoller = new WeatherController();
            var _harborController = new HarborController();

            _boatTypeList = _boatController.GetBoatType();
            _weather = _weatherContoller.Weather;

            _currentStatus = _harborController.CurrentStatus;

        }
    }


}
