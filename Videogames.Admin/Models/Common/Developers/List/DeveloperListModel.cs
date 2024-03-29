﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.Item;

namespace Videogames.Admin.Models.Common.Developers.List
{
    public class DeveloperListModel
    {
        public IList<DeveloperItemModel> Developers { get; set; }
        
        public DeveloperListModel(IList<DeveloperItemModel> developers)
        {
            this.Developers = developers; 
        }
    }
}
