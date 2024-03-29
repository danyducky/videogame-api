﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;

namespace Videogames.Admin.Models.Common.Videogames.Item
{
    public class VideogameForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeveloperId { get; set; }
        public IList<VideogameGenresItemModel> Genres { get; set; }
    }
}
