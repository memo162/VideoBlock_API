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
            services.AddTransient<IRepositoryDbProvider, RepositoryDbProvider>();
            services.AddTransient<IPeliculaRepository, PeliculaRepository>();
            services.AddTransient<IPeliculaService, PeliculaService>();
            services.AddTransient<IPeliculaApplication, PeliculaApplication>();

            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<IRolApplication, RolApplication>();

            services.AddTransient<IRepositoryDbProvider, RepositoryDbProvider>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUsuarioApplication, UsuarioApplication>();

            services.AddTransient<IRepositoryDbProvider, RepositoryDbProvider>();
            services.AddTransient<IReservaRepository, ReservaRepository>();
            services.AddTransient<IReservaService, ReservaService>();
            services.AddTransient<IReservaApplication, ReservaApplication>();

            return services;
        }
    }
}
