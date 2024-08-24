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

        public IActionResult Validaciones2()
        {

            return View();
        }
        public IActionResult Validaciones()
        {

            return View();
        }              

        public IActionResult DemoAjax()
        {

            return View();
        }

        [HttpPost]
        public JsonResult SubmitForm(string name, string email)
        {
            // Aquí puedes agregar lógica para manejar los datos del formulario, como guardarlos en una base de datos
            // Para este ejemplo, simplemente devolvemos un mensaje de éxito

            return Json(new { message = "Formulario enviado con éxito. Gracias, " + name + "!" });
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
