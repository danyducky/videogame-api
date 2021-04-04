using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Videogames.Factories
{
    public class VideogameFactory : IVideogameFactory
    {
        public Videogame Create(string name, int developerId)
        {
            return new Videogame
            {
                Name = name,
                DeveloperId = developerId,
            };
        }
    }
}
