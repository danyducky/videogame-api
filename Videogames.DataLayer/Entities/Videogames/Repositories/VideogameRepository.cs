﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Videogame GetVideogame(int id)
        {
            return db.Videogames.Find(id);
        }

        public List<Videogame> GetVideogames()
        {
            return db.Videogames.ToList();
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