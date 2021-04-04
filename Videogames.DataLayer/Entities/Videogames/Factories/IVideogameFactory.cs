using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Videogames.Factories
{
    public interface IVideogameFactory
    {
        Videogame Create(string name, int developerId);
    }
}
