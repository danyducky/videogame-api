using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Factories;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public class GenreFormHandler : IGenreFormHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IGenreRepository genreRepository;
        private readonly IGenreFactory genreFactory;
        public GenreFormHandler(IEntityRepository<IVideogameEntity> entityRepository, IGenreRepository genreRepository,
            IGenreFactory genreFactory)
        {
            this.entityRepository = entityRepository;
            this.genreRepository = genreRepository;
            this.genreFactory = genreFactory;
        }

        public int HandleCreate(GenreForm form)
        {
            Genre genre = genreFactory.Create(form.Name);

            entityRepository.InsertOnSave(genre);
            entityRepository.SaveChanges();

            return genre.Id;
        }

        public void HandleEdit(int id, GenreForm form)
        {
            var genre = genreRepository.GetGenreById(id);

            if (genre == null) return;
            entityRepository.AttachOnSave(genre);

            genre.Name = form.Name;

            entityRepository.SaveChanges();
        }
    }
}
