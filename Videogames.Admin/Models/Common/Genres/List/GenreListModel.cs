using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Item;

namespace Videogames.Admin.Models.Common.Genres.List
{
    public class GenreListModel
    {
        public IList<GenreItemModel> genreListItemModels { get; set; }

        public GenreListModel(IList<GenreItemModel> genreListItemModels)
        {
            this.genreListItemModels = genreListItemModels;
        }

    }
}
