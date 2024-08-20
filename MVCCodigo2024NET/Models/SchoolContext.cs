using Microsoft.EntityFrameworkCore;

namespace MVCCodigo2024NET.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }




        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

    }
}
