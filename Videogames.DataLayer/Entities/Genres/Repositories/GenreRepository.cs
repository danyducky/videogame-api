using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.DataLayer.Entities.Genres.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly VideogameDbContext db;
        public GenreRepository(VideogameDbContext db)
        {
            this.db = db;
        }

        public void Create(Genre genre)
        {
            db.Genres.Add(genre);
        }

        public void Delete(Genre genre)
        {
            db.Genres.Remove(genre);
        }

        public Genre GetGenreById(int id)
        {
            var item = db.Genres.Find(id);
            return item;
        }

        public List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Genre genre)
        {
            db.Genres.Update(genre);
        }
    }
}
