using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames;
using Videogames.DataLayer.Entities.Videogames.Interfaces;

namespace Videogames.Admin.Models.Common.Videogames.CreateEdit
{
    public class VideogameFormHandler : IVideogameFormHandler
    {
        private readonly IVideogameModelHandler videogameModelHandler;
        private readonly IGenreRepository genreRepository;
        public VideogameFormHandler(IVideogameModelHandler videogameModelHandler, IGenreRepository genreRepository)
        {
            this.videogameModelHandler = videogameModelHandler;
            this.genreRepository = genreRepository;
        }

        public void HandleCreate(VideogameForm form)
        {
            var videogame = new Videogame();
            // Остановился здесь
            videogame.DeveloperId = form.Id;
            videogame.Name = form.Name;
            //videogame.Genres.AddRange(genres);

            videogameModelHandler.Create(videogame);
        }

        public void HandleEdit(int id, VideogameForm form)
        {
            throw new NotImplementedException();
        }
    }
}
