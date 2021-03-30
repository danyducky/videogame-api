using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.Admin.Models.Common.Videogames.CreateEdit
{
    public interface IVideogameModelHandler
    {
        void Create(Videogame videogame);
        void Edit(Videogame videogame);
    }
}
