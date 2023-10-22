using Microsoft.Extensions.DependencyInjection;
using MLApps.Capstone.Forum.Application.Interface.UseCases;

namespace MLApps.Capstone.Forum.Application.UseCases
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUsersApplication, UsersApplication>();
            return services;
        }
    }
}