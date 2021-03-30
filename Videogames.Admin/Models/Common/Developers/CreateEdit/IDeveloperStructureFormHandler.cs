using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;

namespace Videogames.Admin.Models.Common.Developers.CreateEdit
{
    public interface IDeveloperStructureFormHandler
    {
        int HandleCreate(DeveloperItemModel developerItemModel);
        void HandleEdit(int id, DeveloperItemModel developerItemModel);
    }
}
