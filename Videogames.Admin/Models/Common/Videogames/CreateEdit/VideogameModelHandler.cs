using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;
using Videogames.DataLayer.Entities.Videogames.Interfaces;

namespace Videogames.Admin.Models.Common.Videogames.CreateEdit
{
    public class VideogameModelHandler : IVideogameModelHandler
    {
        private readonly IVideogameRepository videogameRepository;
        public VideogameModelHandler(IVideogameRepository videogameRepository)
        {
            this.videogameRepository = videogameRepository;
        }

        public void Create(Videogame videogame)
        {
            videogameRepository.Create(videogame);
            videogameRepository.Save();
        }

        public void Edit(Videogame videogame)
        {
            videogameRepository.Update(videogame);
            videogameRepository.Save();
        }
    }
}
