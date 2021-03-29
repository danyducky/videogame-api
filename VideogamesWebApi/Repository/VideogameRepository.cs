using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideogamesWebApi.Interfaces;
using VideogamesWebApi.Models;

namespace VideogamesWebApi.Repository
{
    public class VideogameRepository : IVideogame
    {
        ApplicationContext db;
        public VideogameRepository(ApplicationContext _db)
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

        public Videogame GetVideogame(int id)
        {
            return db.Videogames.Find(id);
        }

        public async Task<List<Videogame>> GetVideogames()
        {
            return await db.Videogames.ToListAsync();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Videogame videogame)
        {
            db.Videogames.Update(videogame);
        }
    }
}
