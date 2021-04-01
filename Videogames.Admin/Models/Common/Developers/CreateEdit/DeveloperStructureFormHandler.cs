using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public class DeveloperStructureFormHandler : IDeveloperStructureFormHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IDeveloperRepository developerRepository;
        public DeveloperStructureFormHandler(IEntityRepository<IVideogameEntity> entityRepository, IDeveloperRepository developerRepository)
        {
            this.entityRepository = entityRepository;
            this.developerRepository = developerRepository;
        }

        public int HandleCreate(DeveloperForm form)
        {
            var developer = new Developer
            {
                Id = form.Id,
                Name = form.Name
            };

            entityRepository.InsertOnSave(developer);
            entityRepository.SaveChanges();

            return developer.Id;
        }

        public void HandleEdit(int id, DeveloperForm form)
        {
            var developer = developerRepository.GetDeveloperById(id);

            if (developer == null) return;

            developer.Name = form.Name;

            developerRepository.Update(developer);

            entityRepository.SaveChanges();
        }
    }
}
