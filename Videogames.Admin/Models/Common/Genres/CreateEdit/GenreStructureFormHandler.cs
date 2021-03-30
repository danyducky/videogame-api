using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public class GenreStructureFormHandler : IGenreStructureFormHandler
    {
        private readonly IGenreModelHandler genreModelHandler;
        public GenreStructureFormHandler(IGenreModelHandler genreModelHandler)
        {
            this.genreModelHandler = genreModelHandler;
        }

        public int HandleCreate(GenreStructureForm form)
        {
            Genre genre = new Genre { Id = form.Id, Name = form.Name };
            genreModelHandler.Create(genre);
            return genre.Id;
        }

    }
}
