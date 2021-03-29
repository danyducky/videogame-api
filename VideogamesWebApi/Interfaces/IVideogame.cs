using System.Collections.Generic;
using System.Threading.Tasks;
using VideogamesWebApi.Models;

namespace VideogamesWebApi.Interfaces
{
    public interface IVideogame
    {
        Task<List<Videogame>> GetVideogames();
        Videogame GetVideogame(int id);
        void Create(Videogame videogame);
        void Delete(Videogame videogame);
        void Update(Videogame videogame);
        void Save();
    }
}
