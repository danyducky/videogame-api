using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres.Repositories;

namespace Videogames.Admin.Models.Common.Genres.Item
{
    public class GenreItemModelBuilder : IGenreItemModelBuilder
    {
        private readonly IGenreRepository genreRepository;
        public GenreItemModelBuilder(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public GenreItemModel Build(int id)
        {
            var genre = genreRepository.GetGenreById(id);

            var item = new GenreItemModel { Id = genre.Id, Name = genre.Name };

            return item;
        }
    }
}
