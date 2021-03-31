using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Videogames.List
{
    public class VideogameListModel
    {
        public IList<VideogameListItemModel> Videogames { get; set; }
        public VideogameListModel(IList<VideogameListItemModel> videogames)
        {
            Videogames = videogames;
        }
    }


}
