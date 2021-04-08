using Application;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Respository;
using Respository.Interfaces;
using Services;
using Services.Interfaces;

namespace VideoBlock_API.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IReposirotyDbProvider, RepositoryDbProvider>();
            services.AddTransient<IPeliculaRepository, PeliculaRepository>();
            services.AddTransient<IPeliculaService, PeliculaService>();
            services.AddTransient<IPeliculasApplication, PeliculaApplication>();

            return services;
        }
    }
}
