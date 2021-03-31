using System.Collections.Generic;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;

namespace Videogames.DataLayer.Entities.Videogames.Interfaces
{
    public interface IVideogameRepository
    {
        Videogame GetVideogameById(int id);
        void Create(Videogame videogame);
        void Delete(Videogame videogame);
        void Update(Videogame videogame);
        void Save();
    }
}
