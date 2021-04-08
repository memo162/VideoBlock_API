using Microsoft.Extensions.Configuration;
using Models;
using Respository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Respository
{
    public class PeliculaRepository : IPeliculaRepository
    {

        private readonly IReposirotyDbProvider _reposirotyDbProvider;

        public PeliculaRepository(IReposirotyDbProvider reposirotyDbProvider)
        {
            _reposirotyDbProvider = reposirotyDbProvider;
        }

        public List<Pelicula> Get()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula Get(int Id)
        {
            var dbContext = _reposirotyDbProvider.GetDbContext();
            return dbContext.Peliculas.Where(p => p.Id == Id).FirstOrDefault();
        }
    }
}
