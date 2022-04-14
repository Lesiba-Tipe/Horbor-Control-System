
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Harbor_Control_System.Controllers;
using System.Collections.Generic;

namespace Harbor_Control_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> _boardList = new List<string>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var _boatController = new BoatController();
            _boardList = _boatController.GetBoatType();
        }
    }
}
