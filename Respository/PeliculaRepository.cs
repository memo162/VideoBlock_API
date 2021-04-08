using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using Respository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Respository
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly IReposirotyDbProvider _reposirotyDbProvider;

        public PeliculaRepository(IReposirotyDbProvider reposirotyDbProvider)
        {
            _reposirotyDbProvider = reposirotyDbProvider;
        }

        public async Task<List<Pelicula>> Get()
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Peliculas.ToListAsync();
            }
        }

        public async Task<Pelicula> Get(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Peliculas.Where(p => p.Id == id).FirstOrDefaultAsync();
            }
        }

        public async Task<Pelicula> Create(Pelicula pelicula)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                await dbContext.Peliculas.AddAsync(pelicula);
                await dbContext.SaveChangesAsync();

                return pelicula;
            }
        }

        public async Task<Pelicula> Update(Pelicula pelicula) 
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                dbContext.Update(pelicula);
                await dbContext.SaveChangesAsync();
                return await dbContext.Peliculas.Where(p => p.Id == pelicula.Id).FirstOrDefaultAsync();
            }
        }

        public async Task Delete(int id) 
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityPelicula = await dbContext.Peliculas.Where(p => p.Id == id).FirstOrDefaultAsync();
                entityPelicula.Eliminado = true;
                dbContext.Update(entityPelicula);
                await dbContext.SaveChangesAsync();               
            }
        }
    }
}
