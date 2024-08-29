using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCodigo2024NET.Models;

namespace MVCCodigo2024NET.Controllers
{
    public class EnrollmentsAjaxController : Controller
    {

        private readonly SchoolContext _context;

        public EnrollmentsAjaxController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
        [HttpGet] // Decorador para manejar solicitudes GET        
        public IActionResult GetEnrollments(string valor)
        {
            var enrollments = _context.Enrollments
                .Include(x=>x.Course)
                .Include(x=>x.Student)
                .ToList();            

            return Json(enrollments);
        }

        [HttpGet] // Decorador para manejar solicitudes GET        
        public IActionResult GetEnrollments2()
        {
            var enrollments = _context.Enrollments
                .Include(x => x.Course)
                .Include(x => x.Student)
                .ToList();
          
            //Dinamicamente puedo crear un objeto sin tener una clase definida
            var model = enrollments.Select(x => new
            {
                EnrollmentId= x.EnrollmentID,
                Date=x.Date,
                Number=x.Number,
                Student=x.Student.FirstName + " " + x.Student.LastName,
                Course=x.Course.Name
            }).ToList();

            return Json(model);
        }

        [HttpGet] // Decorador para manejar solicitudes GET    
        public IActionResult GetEnrollments3()
        {
            var enrollments = _context.Enrollments
                .Include(x => x.Course)
                .Include(x => x.Student)
                .ToList();
            
            var model = enrollments.Select(x => new EnrollmentModel
            {
                EnrollmentID = x.EnrollmentID,
                Date = x.Date,
                Number = x.Number,
                Student = x.Student.FirstName + " " + x.Student.LastName,
                Course = x.Course.Name
            }).ToList();

            return Json(model);
        }
    }
}
