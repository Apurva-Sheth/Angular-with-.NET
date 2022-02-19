using Microsoft.EntityFrameworkCore;
using MyDemo.Models;

namespace MyDemo.Data
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
        }
    }
}
