using Microsoft.EntityFrameworkCore;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.DataLayer
{
    public class VideogameDbContext : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public VideogameDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=videogames;Username=postgres;Password=1");
        }
    }
}
