using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public class GenreModelHandler : IGenreModelHandler
    {
        private readonly IGenreRepository genreRepository;
        public GenreModelHandler(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public void Create(Genre genre)
        {
            genreRepository.Create(genre);
            genreRepository.Save();
        }

        public void Edit(Genre genre)
        {
            genreRepository.Update(genre);
            genreRepository.Save();
        }
    }
}
