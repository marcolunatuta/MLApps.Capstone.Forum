using Microsoft.Extensions.DependencyInjection;
using MLApps.Capstone.Forum.Application.Validation.Rules;

namespace MLApps.Capstone.Forum.Application.Validation
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddTransient<UsersValidator>();
            return services;
        }
    }
}