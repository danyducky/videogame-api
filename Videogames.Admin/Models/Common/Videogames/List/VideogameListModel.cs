using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.Admin.Models.Common.Videogames.List
{
    public class VideogameListModel
    {
        public IList<Videogame> Videogames { get; set; }
        public VideogameListModel(IList<Videogame> videogames)
        {
            Videogames = videogames;
        }
    }
}
