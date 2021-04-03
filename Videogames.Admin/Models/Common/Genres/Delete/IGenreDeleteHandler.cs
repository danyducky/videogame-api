using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Genres.Delete
{
    public interface IGenreDeleteHandler
    {
        void HandleDelete(int id);
    }
}
