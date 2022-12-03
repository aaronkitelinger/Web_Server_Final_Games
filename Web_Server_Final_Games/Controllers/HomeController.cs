using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_Server_Final_Games.Models;

namespace Web_Server_Final_Games.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Repository<Games> repository { get; set; }

        public HomeController(GamesContext ctx) 
        {
            repository = new Repository<Games>(ctx);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonalInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {

            return View();
        }

        public IActionResult OuterWilds()
        {
            return View();
        }

        public IActionResult EldenRing()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
