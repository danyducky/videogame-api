using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Developers.Item
{
    public interface IDeveloperItemModelBuilder
    {
        DeveloperItemModel Build(int id);
    }
}
