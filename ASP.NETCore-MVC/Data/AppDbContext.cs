using ASP.NETCore_MVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        
        public DbSet<Student> Students { get; set; }
    }
}
