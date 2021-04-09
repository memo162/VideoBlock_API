using Microsoft.EntityFrameworkCore;
using Models;

namespace Respository
{
    public class RepositoryDbContext : DbContext
    {
        private readonly string connectionString;

        public RepositoryDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
