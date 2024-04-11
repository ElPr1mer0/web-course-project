using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DataBaseConfiguration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Grids> Grids { get; set; }
        public DbSet<Columns> Columns { get; set; }
    }
}
