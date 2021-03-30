using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Genres;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public interface IGenreModelHandler
    {
        void Create(Genre genre);
        void Edit(Genre genre);
    }
}
