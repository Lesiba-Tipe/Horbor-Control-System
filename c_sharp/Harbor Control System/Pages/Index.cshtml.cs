
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Harbor_Control_System.Controllers;
using System.Collections.Generic;
using Harbor_Control_System.Entity;

namespace Harbor_Control_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> _boardList = new List<string>();
        public Weather _weather;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var _boatController = new BoatController();
            var _weatherContoller = new WeatherController();

            _boardList = _boatController.GetBoatType();
            _weather = _weatherContoller.Weather;
            
        }
    }
}
