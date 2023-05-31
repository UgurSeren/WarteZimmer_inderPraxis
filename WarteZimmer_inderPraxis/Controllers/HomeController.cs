using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarteZimmer_inderPraxis.Models;

namespace WarteZimmer_inderPraxis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Index2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index3(Patienten p)
        {
            Info.AddPatient(p);   
            return View("Anzeige",Info.x);
        }
        public IActionResult Index1()
        {
            
            return View("Index1");
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Anzeige()
        {

            return View(Info.queue);
        }


        public IActionResult Privacy()
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