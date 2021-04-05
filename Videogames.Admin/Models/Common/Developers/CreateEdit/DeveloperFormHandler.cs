using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Developers.Factories;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public class DeveloperFormHandler : IDeveloperFormHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IDeveloperRepository developerRepository;
        private readonly IDeveloperFactory developerFactory;
        public DeveloperFormHandler(IEntityRepository<IVideogameEntity> entityRepository, IDeveloperRepository developerRepository, 
            IDeveloperFactory developerFactory)
        {
            this.entityRepository = entityRepository;
            this.developerRepository = developerRepository;
            this.developerFactory = developerFactory;
        }

        public int HandleCreate(DeveloperForm form)
        {
            var developer = developerFactory.Create(form.Name);

            entityRepository.InsertOnSave(developer);
            entityRepository.SaveChanges();

            return developer.Id;
        }

        public void HandleEdit(int id, DeveloperForm form)
        {
            var developer = developerRepository.GetDeveloperById(id);

            if (developer == null) return;
            entityRepository.AttachOnSave(developer);

            developer.Name = form.Name;

            entityRepository.SaveChanges();
        }
    }
}
