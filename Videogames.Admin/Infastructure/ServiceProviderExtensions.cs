using Microsoft.Extensions.DependencyInjection;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Developers.List;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Genres.List;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.Admin.Models.Common.Videogames.List;
using Videogames.DataLayer;
using Videogames.DataLayer.Entities;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Entities.Videogames.Repositories;
using Videogames.DataLayer.Infastructure;

namespace Videogames.Admin.Infastructure
{
    public static class ServiceProviderExtensions
    {
        public static void AddBuilders(this IServiceCollection services)
        {
            services.AddDbContext<VideogameDbContext>(ServiceLifetime.Transient);
            services.AddScoped<IEntityRepository<IVideogameEntity>, EntityRepository<IVideogameEntity>>();

            services.AddScoped<IVideogameRepository, VideogameRepository>();
            services.AddScoped<IVideogameFormHandler, VideogameFormHandler>();
            services.AddScoped<IVideogameItemModelBuilder, VideogameItemModelBuilder>();
            services.AddScoped<IVideogameListModelBuilder, VideogameListModelBuilder>();
            //
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IGenreStructureFormHandler, GenreStructureFormHandler>();
            services.AddScoped<IGenreListModelBuilder, GenreListModelBuilder>();
            services.AddScoped<IGenreItemModelBuilder, GenreItemModelBuilder>();
            //
            services.AddScoped<IDeveloperRepository, DeveloperRepository>();
            services.AddScoped<IDeveloperStructureFormHandler, DeveloperStructureFormHandler>();
            services.AddScoped<IDeveloperItemModelBuilder, DeveloperItemModelBuilder>();
            services.AddScoped<IDeveloperListModelBuilder, DeveloperListModelBuilder>();
            
            
        }
    }
}
