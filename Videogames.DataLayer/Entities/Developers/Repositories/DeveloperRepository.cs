﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Infastructure;

namespace Videogames.DataLayer.Entities.Developers.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        public DeveloperRepository(IEntityRepository<IVideogameEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public Developer GetDeveloperById(int id)
        {
            return entityRepository.GetTable<Developer>().FirstOrDefault(dev => dev.Id == id);
        }

        public List<Developer> GetDevelopers()
        {
            return entityRepository.GetTable<Developer>().ToList();
        }
    }
}
