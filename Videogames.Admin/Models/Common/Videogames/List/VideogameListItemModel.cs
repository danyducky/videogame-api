using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.DataLayer.Entities.Developers;
using Videogames.DataLayer.Entities.Genres;

namespace Videogames.Admin.Models.Common.Videogames.List
{
    public class VideogameListItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeveloperItemModel Developer { get; set; }
        public IList<string> Genres { get; set; }

        public VideogameListItemModel(int Id, string Name, DeveloperItemModel Developer, IList<string> Genres)
        {
            this.Id = Id;
            this.Name = Name;
            this.Developer = Developer;
            this.Genres = Genres;
        }
    }
}
