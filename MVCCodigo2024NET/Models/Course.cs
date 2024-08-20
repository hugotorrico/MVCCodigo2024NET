using System.ComponentModel.DataAnnotations;

namespace MVCCodigo2024NET.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? Name { get; set; }

        
        public string? Description { get; set; }
        public string Nuevo { get; set; }

        [Range(10,20)]
        public int Credit { get; set; }
    }
}
