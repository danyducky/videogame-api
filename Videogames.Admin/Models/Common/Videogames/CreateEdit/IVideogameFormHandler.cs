using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Videogames.Item;

namespace Videogames.Admin.Models.Common.Videogames.CreateEdit
{
    public interface IVideogameFormHandler
    {
        int HandleCreate(VideogameForm form);
        void HandleEdit(int id, VideogameForm form);
    }
}
