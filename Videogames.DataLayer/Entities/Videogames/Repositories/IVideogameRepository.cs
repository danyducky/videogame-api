using System.Collections.Generic;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;

namespace Videogames.DataLayer.Entities.Videogames.Interfaces
{
    public interface IVideogameRepository
    {
        Videogame GetVideogameById(int id);
        List<Videogame> GetVideogames();
        List<Videogame> GetGenres();
        List<Videogame> GetIncluded();
        Videogame GetIncludedById(int id);
    }
}
