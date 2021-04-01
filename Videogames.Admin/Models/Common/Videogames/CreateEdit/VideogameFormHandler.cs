﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Models.Common.Videogames.CreateEdit
{
    public class VideogameFormHandler : IVideogameFormHandler
    {
        private readonly IEntityRepository<IVideogameEntity> entityRepository;
        private readonly IVideogameRepository videogameRepository;
        private readonly IDeveloperRepository developerRepository;
        private readonly IGenreRepository genreRepository;
        public VideogameFormHandler(IEntityRepository<IVideogameEntity> entityRepository, IVideogameRepository videogameRepository, IDeveloperRepository developerRepository, IGenreRepository genreRepository)
        {
            this.entityRepository = entityRepository;
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

            entityRepository.InsertOnSave(videogame);
            entityRepository.SaveChanges();

            return videogame.Id;
        }

        public void HandleEdit(int id, VideogameForm form)
        {
            var videogame = videogameRepository.GetIncludedById(id);
            var genreVideogameList = videogame.Genres.ToList();

            var formGenreNames = form.Genres.Select(g => g.Name).ToList();
            var genresForVideogame = genreRepository.GetGenres().Where(g => formGenreNames.Contains(g.Name)).ToList();

            foreach(var genre in genreVideogameList)
            {
                genre.Videogames.Remove(videogame);
                videogame.Genres.Remove(genre);
            }

            videogame.Name = form.Name;
            videogame.DeveloperId = form.DeveloperId;

            foreach(var genre in genresForVideogame)
            {
                genre.Videogames.Add(videogame);
            }


            videogameRepository.Update(videogame);
            entityRepository.SaveChanges();
        }
    }
}
