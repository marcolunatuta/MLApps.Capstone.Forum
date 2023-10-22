using MLApps.Capstone.Forum.Infrastructure.Persistance;
using MLApps.Capstone.Forum.Transversal.Common.Interfaces;
using MLApps.Capstone.Forum.Transversal.Logging;

namespace MLApps.Capstone.Forum.WebApi.Modules.Services
{
    public static class DependenciesExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IAppLogger<>), typeof(AppLogger<>));

            services.AddPersistance();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            return services;
        }
    }
}