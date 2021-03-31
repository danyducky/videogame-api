using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Developers.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        private readonly VideogameDbContext videogameDbContext;
        public DeveloperRepository(VideogameDbContext videogameDbContext)
        {
            this.videogameDbContext = videogameDbContext;
        }

        public void Create(Developer developer)
        {
            videogameDbContext.Developers.Add(developer);
        }

        public void Delete(Developer developer)
        {
            videogameDbContext.Remove(developer);
        }

        public Developer GetDeveloperById(int Id)
        {
            return videogameDbContext.Developers.FirstOrDefault(dev => dev.Id == Id);
        }

        public List<Developer> GetDevelopers()
        {
            return videogameDbContext.Developers.ToList();
        }

        public void Save()
        {
            videogameDbContext.SaveChanges();
        }

        public void Update(Developer developer)
        {
            videogameDbContext.Developers.Update(developer);
        }
    }
}
