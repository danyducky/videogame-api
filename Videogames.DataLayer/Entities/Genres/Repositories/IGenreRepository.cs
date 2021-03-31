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
        Genre GetGenreById(int Id);
        void Create(Genre genre);
        void Delete(Genre genre);
        void Update(Genre genre);
        void Save();
    }
}
