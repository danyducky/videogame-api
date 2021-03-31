using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Videogames.Interfaces;

namespace Videogames.DataLayer.Entities.Videogames.Repositories
{
    public class VideogameRepository : IVideogameRepository
    {
        private readonly VideogameDbContext db;

        public VideogameRepository(VideogameDbContext _db)
        {
            db = _db;
        }

        public void Create(Videogame videogame)
        {
            db.Videogames.Add(videogame);
        }

        public void Delete(Videogame videogame)
        {
            db.Videogames.Remove(videogame);
        }

        public Videogame GetVideogameById(int id)
        {
            return db.Videogames.Find(id);
        }

        public List<Videogame> GetGenres()
        {
            return db.Videogames.Include(vd => vd.Genres).ToList();
        }

        public List<Videogame> GetVideogames()
        {
            return db.Videogames.ToList();
        }

        public void InsertRange(Videogame videogame, IList<Genre> genres)
        {
            var game = db.Videogames.Find(videogame);
            game.Genres.AddRange(genres);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Videogame videogame)
        {
            db.Videogames.Update(videogame);
        }
        
        public List<Videogame> GetIncluded()
        {
            return db.Videogames.Include(vd => vd.Developer).Include(vd => vd.Genres).ToList();
        }
    }
}
