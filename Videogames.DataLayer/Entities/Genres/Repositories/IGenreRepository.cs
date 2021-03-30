using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Genres.Repositories
{
    public interface IGenreRepository
    {
        List<Genre> GetGenres();
        void Create(Genre genre);
        void Delete(Genre genre);
        void Update(Genre genre);
        void Save();
    }
}
