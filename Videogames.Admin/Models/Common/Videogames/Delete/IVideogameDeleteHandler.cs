﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Videogames.Delete
{
    public interface IVideogameDeleteHandler
    {
        void HandleDelete(int id);
    }
}
