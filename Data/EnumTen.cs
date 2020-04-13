using EnumTen.Models;
using Microsoft.EntityFrameworkCore;

namespace EnumTen.Data
{
    //Creates a new database context named StudentInformationContext
    public class EnumTenContext : DbContext
    {
        public EnumTenContext(DbContextOptions<EnumTenContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Meal> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}