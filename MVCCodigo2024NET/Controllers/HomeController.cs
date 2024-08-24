using Microsoft.AspNetCore.Mvc;
using MVCCodigo2024NET.Models;
using System.Diagnostics;

namespace MVCCodigo2024NET.Controllers
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

        public IActionResult Demo()
        {

            return View();
        }
        public IActionResult Validaciones()
        {

            return View();
        }
        public IActionResult Validaciones2()
        {

            return View();
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
