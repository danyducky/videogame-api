using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Developers.Repositories;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public class DeveloperStructureFormHandler : IDeveloperStructureFormHandler
    {
        private readonly IDeveloperModelHandler developerModelHandler;
        private readonly IDeveloperRepository developerRepository;
        public DeveloperStructureFormHandler(IDeveloperModelHandler developerModelHandler, IDeveloperRepository developerRepository)
        {
            this.developerModelHandler = developerModelHandler;
            this.developerRepository = developerRepository;
        }

        public int HandleCreate(DeveloperItemModel developerItemModel)
        {
            var developer = new Developer
            {
                Id = developerItemModel.Id,
                Name = developerItemModel.Name
            };

            developerModelHandler.Create(developer);
            return developer.Id;
        }

        public void HandleEdit(int id, DeveloperItemModel developerItemModel)
        {
            var developer = developerRepository.GetDeveloperById(id);

            if (developer == null) return;

            developer.Name = developerItemModel.Name;

            developerModelHandler.Edit(developer);
        }
    }
}
