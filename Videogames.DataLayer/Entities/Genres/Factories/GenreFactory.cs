using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Genres.Factories
{
    public class GenreFactory : IGenreFactory
    {
        public Genre Create(string name)
        {
            return new Genre
            {
                Name = name,
            };
        }
    }
}
