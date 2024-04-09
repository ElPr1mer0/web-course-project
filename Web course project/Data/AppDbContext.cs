using Microsoft.EntityFrameworkCore;
using Web_course_project.Data.Entities;

namespace Web_course_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
        public DbSet<Users> Users { get; set; }
    }
}
