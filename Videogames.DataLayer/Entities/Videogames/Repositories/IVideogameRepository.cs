using System.Collections.Generic;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Videogames.Interfaces
{
    public interface IVideogameRepository
    {
        //Task<List<Videogame>> GetVideogames();
        Videogame GetVideogame(int id);
        void Create(Videogame videogame);
        void Delete(Videogame videogame);
        void Update(Videogame videogame);
        void Save();
    }
}
