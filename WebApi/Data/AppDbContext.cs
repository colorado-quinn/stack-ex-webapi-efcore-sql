using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string? _connString;

        public AppDbContext(IConfiguration config)
        {
            _connString = config.GetConnectionString("DatabaseConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
