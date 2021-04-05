using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;
using Videogames.DataLayer.Infastructure;

namespace Videogames.DataLayer.Entities.Genres.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        public GenreRepository(IEntityRepository<IVideogameEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public Genre GetGenreById(int id)
        {
            return entityRepository.GetTable<Genre>().FirstOrDefault(g => g.Id == id);
        }

        public List<Genre> GetGenres()
        {
            return entityRepository.GetTableInternal<Genre>().ToList();
        }
    }
}
