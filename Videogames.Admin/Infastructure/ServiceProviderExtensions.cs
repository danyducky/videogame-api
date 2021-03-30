using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Genres.List;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.DataLayer;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Entities.Videogames.Repositories;

namespace Videogames.Admin.Infastructure
{
    public static class ServiceProviderExtensions
    {
        public static void AddBuilders(this IServiceCollection services)
        {
            services.AddDbContext<VideogameDbContext>(ServiceLifetime.Transient);

            services.AddSingleton<IVideogameRepository, VideogameRepository>();
            services.AddSingleton<IVideogameModelHandler, VideogameModel>();
            services.AddSingleton<IGenreRepository, GenreRepository>();
            services.AddSingleton<IGenreModelHandler, GenreModel>();
            services.AddSingleton<IGenreStructureFormHandler, GenreStructureFormHandler>();
            services.AddSingleton<IGenreListModelBuilder, GenreListModelBuilder>();
            services.AddSingleton<IGenreItemModelBuilder, GenreItemModelBuilder>();
            
            
        }
    }
}
