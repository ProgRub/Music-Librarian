using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DB
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Repositories
            services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddSingleton<IAlbumRepository, AlbumRepository>();
            services.AddSingleton<IArtistRepository, ArtistRepository>();
            services.AddSingleton<IDirectoriesRepository, DirectoriesRepository>();
            services.AddSingleton<ISongHasContributingArtistsRepository, SongHasContributingArtistsRepository>();
            services.AddSingleton<ISongRepository, SongRepository>();
            services.AddSingleton<IUniFileFormatRepository, UniFileFormatRepositoryRepository>();
            services.AddSingleton<IWorkoutHasTimesRepository, WorkoutHasTimesRepository>();
            services.AddSingleton<IWorkoutRepository, WorkoutRepository>();
            services.AddSingleton<IWorkoutTimeRepository, WorkoutTimeRepository>();
            #endregion
        }
    }
}