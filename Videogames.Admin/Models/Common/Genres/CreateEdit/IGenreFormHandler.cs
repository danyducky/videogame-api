using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public interface IGenreFormHandler
    {
        int HandleCreate(GenreForm form);
        void HandleEdit(int id, GenreForm form);
    }
}
