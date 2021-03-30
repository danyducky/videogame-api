using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Developers.Repositories;

namespace Videogames.Admin.Models.Common.Developers.Item
{
    public class DeveloperItemModelBuilder : IDeveloperItemModelBuilder
    {
        private readonly IDeveloperRepository developerRepository;
        public DeveloperItemModelBuilder(IDeveloperRepository developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public DeveloperItemModel Build(int id)
        {
            var developer = developerRepository.GetDeveloperById(id);

            var item = new DeveloperItemModel
            {
                Id = developer.Id,
                Name = developer.Name
            };

            return item;
        }
    }
}
