using Microsoft.EntityFrameworkCore;

namespace RazorEntityApp.Models
{
    public class AppRazorContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public AppRazorContext(DbContextOptions<AppRazorContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
