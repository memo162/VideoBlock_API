using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoBlock_API
{
    internal class PeliculaContext : DbContext
    {
        private readonly string connectionString;

        public PeliculaContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
