using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
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
            var videogame = videogameRepository.GetIncludedById(id);

            var genreNames = videogame.Genres.Select(g => g.Name).ToList();

            var developer = developerRepository.GetDeveloperById(videogame.DeveloperId);

            var devModel = new DeveloperItemModel
            {
                Id = developer.Id,
                Name = developer.Name,
            };

            return new VideogameItemModel(videogame.Id, videogame.Name, devModel, genreNames);

        }
    }
}
