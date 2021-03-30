using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.CreateEdit;

namespace Videogames.Admin.Models.Common.Genres.List
{
    public class GenreListModel
    {
        public IList<GenreStructureForm> genreStructForms { get; set; }
    }
}
