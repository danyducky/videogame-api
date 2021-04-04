using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Genres.Factories
{
    public interface IGenreFactory
    {
        Genre Create(string name);
    }
}
