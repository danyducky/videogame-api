using Microsoft.EntityFrameworkCore;

namespace VideogamesWebApi.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated(); // Create database if not exists
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
