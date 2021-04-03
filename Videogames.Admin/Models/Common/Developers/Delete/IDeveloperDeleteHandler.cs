using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Developers.Delete
{
    public interface IDeveloperDeleteHandler
    {
        void HandleDelete(int id);
    }
}
