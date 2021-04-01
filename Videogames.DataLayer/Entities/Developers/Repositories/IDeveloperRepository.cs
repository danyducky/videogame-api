using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Developers.Repositories
{
    public interface IDeveloperRepository
    {
        List<Developer> GetDevelopers();
        Developer GetDeveloperById(int id);
        void Create(Developer developer);
        void Delete(Developer developer);
        void Update(Developer developer);
    }
}
