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
        private readonly IVideogameRepository videogameRepository;
        private readonly IDeveloperRepository developerRepository;
        private readonly IGenreRepository genreRepository;
        public VideogameFormHandler(IVideogameRepository videogameRepository, IDeveloperRepository developerRepository, IGenreRepository genreRepository)
        {
            this.videogameRepository = videogameRepository;
            this.developerRepository = developerRepository;
            this.genreRepository = genreRepository;
        }

        public int HandleCreate(VideogameForm form)
        {
            var g = form.Genres.Select(genre => genre.Name);
            var genres = genreRepository.GetGenres().Where(genre => g.Contains(genre.Name)).ToList();

            var videogame = new Videogame
            {
                Name = form.Name,
                DeveloperId = form.DeveloperId
            };

            foreach (var genre in genres)
            {
                genre.Videogames.Add(videogame);
            }

            videogameRepository.Create(videogame);
            videogameRepository.Save();
            genreRepository.Save();

            return videogame.Id;
        }

        public void HandleEdit(int id, VideogameForm form)
        {

        }
    }
}
