using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Genres;

namespace Videogames.Admin.Models.Common.Videogames.Item
{
    public class VideogameItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Developer Developer { get; set; }
        public IList<Genre> Genres { get; set; }
    }
}
