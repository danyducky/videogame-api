using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Videogames.Item
{
    public interface IVideogameItemModelBuilder
    {
        VideogameItemModel Build(int id);
    }
}
