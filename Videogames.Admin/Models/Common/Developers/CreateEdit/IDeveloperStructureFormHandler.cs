using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public interface IDeveloperStructureFormHandler
    {
        int HandleCreate(DeveloperForm developerItemModel);
        void HandleEdit(int id, DeveloperForm developerItemModel);
    }
}
