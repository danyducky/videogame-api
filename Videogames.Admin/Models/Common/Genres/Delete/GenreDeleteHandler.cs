using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Genres.Delete
{
    public class GenreDeleteHandler : IGenreDeleteHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IGenreRepository genreRepository;
        public GenreDeleteHandler(IEntityRepository<IVideogameEntity> entityRepository, IGenreRepository genreRepository)
        {
            this.entityRepository = entityRepository;
            this.genreRepository = genreRepository;
        }
        public void HandleDelete(int id)
        {
            var genre = genreRepository.GetGenreById(id);
            entityRepository.DeleteOnSave(genre);
            entityRepository.SaveChanges();
        }
    }
}
