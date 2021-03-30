using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Developers;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public interface IDeveloperModelHandler
    {
        void Create(Developer developer);
        void Edit(Developer developer);
    }
}
