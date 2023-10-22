using Microsoft.Extensions.DependencyInjection;
using MLApps.Capstone.Forum.Application.Interface.Repositories;
using MLApps.Capstone.Forum.Persistance.Context;
using MLApps.Capstone.Forum.Persistance.Repositories;

namespace MLApps.Capstone.Forum.Infrastructure.Persistance
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            services.AddSingleton<DatabaseContext>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            return services;
        }
    }
}