using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        private readonly IConfiguration configuration;
        public VideogameDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Videogames)
                .WithMany(v => v.Genres)
                .UsingEntity(gv => gv.ToTable("genre_videogame"));
        }

    }
}
