using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Infastructure;

namespace Videogames.DataLayer.Entities.Videogames.Repositories
{
    public class VideogameRepository : IVideogameRepository
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        public VideogameRepository(IEntityRepository<IVideogameEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public Videogame GetVideogameById(int id)
        {
            return entityRepository.GetTable<Videogame>().FirstOrDefault(vg => vg.Id == id);
        }

        public List<Videogame> GetGenres()
        {
            return entityRepository.GetTableInternal<Videogame>().Include(vg => vg.Genres).ToList();
        }

        public List<Videogame> GetVideogames()
        {
            return entityRepository.GetTable<Videogame>().ToList();
        }

        public List<Videogame> GetIncluded()
        {
            return entityRepository.GetTableInternal<Videogame>()
                .Include(vd => vd.Developer)
                .Include(vd => vd.Genres)
                .ToList();
        }

        public Videogame GetIncludedById(int id)
        {   
            return entityRepository.GetTableInternal<Videogame>()
                .Include(vd => vd.Developer)
                .Include(vd => vd.Genres)
                .FirstOrDefault(vd => vd.Id == id);
        }
    }
}
