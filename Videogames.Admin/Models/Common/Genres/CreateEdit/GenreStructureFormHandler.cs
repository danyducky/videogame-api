using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;


namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public class GenreStructureFormHandler : IGenreStructureFormHandler
    {
        private readonly IGenreModelHandler genreModelHandler;
        private readonly IGenreRepository genreRepository;
        public GenreStructureFormHandler(IGenreModelHandler genreModelHandler, IGenreRepository genreRepository)
        {
            this.genreModelHandler = genreModelHandler;
            this.genreRepository = genreRepository;
        }

        public int HandleCreate(GenreItemModel form)
        {
            Genre genre = new Genre { Id = form.Id, Name = form.Name };
            genreModelHandler.Create(genre);
            return genre.Id;
        }

        public void HandleEdit(int id, GenreItemModel form)
        {
            var genre = genreRepository.GetGenreById(id);

            if (genre == null) return;

            genre.Name = form.Name;

            genreModelHandler.Edit(genre);
        }
    }
}
