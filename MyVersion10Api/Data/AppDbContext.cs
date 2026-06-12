using Microsoft.EntityFrameworkCore;
using MyVersion10Api.Entities;

namespace MyVersion10Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> AccountUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
