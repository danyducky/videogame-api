using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public class GenreStructureFormHandler : IGenreStructureFormHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IGenreRepository genreRepository;
        public GenreStructureFormHandler(IEntityRepository<IVideogameEntity> entityRepository, IGenreRepository genreRepository)
        {
            this.entityRepository = entityRepository;
            this.genreRepository = genreRepository;
        }

        public int HandleCreate(GenreForm form)
        {
            Genre genre = new Genre { Id = form.Id, Name = form.Name };

            entityRepository.InsertOnSave(genre);
            entityRepository.SaveChanges();

            return genre.Id;
        }

        public void HandleEdit(int id, GenreForm form)
        {
            var genre = genreRepository.GetGenreById(id);

            if (genre == null) return;

            genre.Name = form.Name;

            genreRepository.Update(genre);

            entityRepository.SaveChanges();
        }
    }
}
