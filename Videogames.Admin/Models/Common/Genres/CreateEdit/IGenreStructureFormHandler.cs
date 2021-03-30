using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public interface IGenreStructureFormHandler
    {
        int HandleCreate(GenreItemModel form);
        void HandleEdit(int id, GenreItemModel form);
    }
}
