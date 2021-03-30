using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Genres.Item
{
    public interface IGenreItemModelBuilder
    {
        GenreItemModel Build(int id);
    }
}
