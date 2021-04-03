using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Videogames.Delete
{
    public class VideogameDeleteHandler : IVideogameDeleteHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IVideogameRepository videogameRepository;
        public VideogameDeleteHandler(IEntityRepository<IVideogameEntity> entityRepository, IVideogameRepository videogameRepository)
        {
            this.entityRepository = entityRepository;
            this.videogameRepository = videogameRepository;
        }
        public void HandleDelete(int id)
        {
            var videogame = videogameRepository.GetVideogameById(id);
            entityRepository.DeleteOnSave(videogame);
            entityRepository.SaveChanges();
        }
    }
}
