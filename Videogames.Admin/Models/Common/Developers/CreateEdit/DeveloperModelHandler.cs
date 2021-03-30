using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Developers.Repositories;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public class DeveloperModelHandler : IDeveloperModelHandler
    {
        private readonly IDeveloperRepository developerRepository;
        public DeveloperModelHandler(IDeveloperRepository developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public void Create(Developer developer)
        {
            developerRepository.Create(developer);
            developerRepository.Save();
        }

        public void Edit(Developer developer)
        {
            developerRepository.Update(developer);
            developerRepository.Save();
        }
    }
}
