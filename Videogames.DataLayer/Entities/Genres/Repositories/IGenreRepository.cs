using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.DataLayer.Entities.Genres.Repositories
{
    public interface IGenreRepository
    {
        List<Genre> GetGenres();
        Genre GetGenreById(int id);
    }
}
