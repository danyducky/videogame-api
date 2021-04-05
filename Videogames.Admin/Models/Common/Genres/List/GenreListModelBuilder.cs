using System.Linq;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities.Genres.Repositories;

namespace Videogames.Admin.Models.Common.Genres.List
{
    public class GenreListModelBuilder : IGenreListModelBuilder
    {
        private readonly IGenreRepository genreRepository;
        public GenreListModelBuilder(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }


        public GenreListModel Build()
        {
            var genres = genreRepository.GetGenres();

            var modelList = genres.Select(genre => new GenreItemModel()
            {
                Id = genre.Id,
                Name = genre.Name
            }).ToList();

            return new GenreListModel(modelList);

        }
    }
}
