using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Genres.CreateEdit
{
    public interface IGenreStructureFormHandler
    {
        int HandleCreate(GenreStructureForm form);
    }
}
