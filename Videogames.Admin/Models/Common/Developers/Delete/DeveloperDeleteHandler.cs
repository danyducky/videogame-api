using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Developers.Delete
{
    public class DeveloperDeleteHandler : IDeveloperDeleteHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IDeveloperRepository developerRepository;
        public DeveloperDeleteHandler(IEntityRepository<IVideogameEntity> entityRepository, IDeveloperRepository developerRepository)
        {
            this.entityRepository = entityRepository;
            this.developerRepository = developerRepository;
        }

        public void HandleDelete(int id)
        {
            var developer = developerRepository.GetDeveloperById(id);
            entityRepository.DeleteOnSave(developer);
            entityRepository.SaveChanges();
        }
    }
}
