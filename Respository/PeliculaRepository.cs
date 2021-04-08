using Models;
using Respository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Respository
{
    public class PeliculaRepository : IPeliculaReposiroty
    {
        public readonly RepositoryDbContext _repositoryDbContext;

        public PeliculaRepository(RepositoryDbContext repositoryDbContext) 
        {
            _repositoryDbContext = repositoryDbContext;
        }

        public List<Pelicula> Get()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula Get(int Id)
        {
            return _repositoryDbContext.Peliculas.Where(p => p.Id == Id).FirstOrDefault();
        }
    }
}
