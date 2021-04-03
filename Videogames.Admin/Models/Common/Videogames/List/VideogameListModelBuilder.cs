using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames;
using Videogames.DataLayer.Entities.Videogames.Interfaces;

namespace Videogames.Admin.Models.Common.Videogames.List
{
    public class VideogameListModelBuilder : IVideogameListModelBuilder
    {
        private readonly IVideogameRepository videogameRepository;
        public VideogameListModelBuilder(IVideogameRepository videogameRepository)
        {
            this.videogameRepository = videogameRepository;
        }

        public VideogameListModel Build()
        {
            var videogames = videogameRepository.GetIncluded();


            var model = videogames
                .Select(vg => new VideogameListItemModel(
                    vg.Id, 
                    vg.Name,
                    new DeveloperItemModel { Id = vg.Developer.Id, Name = vg.Developer.Name },
                    vg.Genres.Select(g => g.Name).ToList())
                ).ToList();


            return new VideogameListModel(model);
        }
    }
}
