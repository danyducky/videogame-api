using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.DataLayer.Entities.Developers.Repositories;

namespace Videogames.Admin.Models.Common.Developers.List
{
    public class DeveloperListModelBuilder : IDeveloperListModelBuilder
    {
        private readonly IDeveloperRepository developerRepository;
        public DeveloperListModelBuilder(IDeveloperRepository developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public DeveloperListModel Build()
        {
            var developers = developerRepository.GetDevelopers();

            var modelList = developers.Select(developer => new DeveloperItemModel
            {
                Id = developer.Id,
                Name = developer.Name
            }).ToList();

            return new DeveloperListModel(modelList);
        }
    }
}
