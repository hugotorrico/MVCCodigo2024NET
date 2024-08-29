using Microsoft.AspNetCore.Mvc;
using MVCCodigo2024NET.Models;

namespace MVCCodigo2024NET.Controllers
{
    public class CoursesAjaxController : Controller
    {
        private readonly SchoolContext _context;

        public CoursesAjaxController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
        public IActionResult IndexAjax()
        {            
            return View();
        }

        public IActionResult CreateCourse()
        {
            return PartialView("_CreateCoursePartial");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm(string name, string description, int credit)
        {
            try
            {
                var course = new Course
                {
                    Name = name,
                    Description = description,
                    Credit = credit,
                    Nuevo=string.Empty
                };
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return Json(new { message = "Estudiante registrado con éxito." });
            }
            catch (Exception ex)
            {

                return Json(new { message = ex.Message });
            }
          

          

           
        }

        [HttpGet] // Decorador para manejar solicitudes GET
        public IActionResult GetCourses()
        {
            var courses = _context.Courses.ToList();
            return Json(courses);
        }
    }
}
