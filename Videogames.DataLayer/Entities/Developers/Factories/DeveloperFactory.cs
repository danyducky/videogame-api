using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Developers.Factories
{
    public class DeveloperFactory : IDeveloperFactory
    {
        public Developer Create(string name)
        {
            return new Developer
            {
                Name = name,
            };
        }
    }
}
