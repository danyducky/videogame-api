using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames.Interfaces;

namespace Videogames.Admin.Models.Common.Videogames.Item
{
    public class VideogameItemModelBuilder : IVideogameItemModelBuilder
    {
        private readonly IVideogameRepository videogameRepository;
        private readonly IDeveloperRepository developerRepository;
        private readonly IGenreRepository genreRepository;
        public VideogameItemModelBuilder(IVideogameRepository videogameRepository, IDeveloperRepository developerRepository, IGenreRepository genreRepository)
        {
            this.videogameRepository = videogameRepository;
            this.developerRepository = developerRepository;
            this.genreRepository = genreRepository;
        }

        public VideogameItemModel Build(int id)
        {
            var videogame = videogameRepository.GetVideogameById(id);
            var genres = genreRepository.GetGenres();

            var model = new VideogameItemModel
            {
                Id = videogame.Id,
                Name = videogame.Name,
                Developer = developerRepository.GetDeveloperById(videogame.DeveloperId),
                //Genres = genres
            };

            return model;

        }
    }
}
