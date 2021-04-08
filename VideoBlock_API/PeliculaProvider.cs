using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoBlock_API
{
    internal class PeliculaProvider : IPeliculaProvider
    {
        public readonly PeliculaContext peliculaContext;

        public PeliculaProvider(PeliculaContext peliculaContext) 
        {
            this.peliculaContext = peliculaContext;
        }

        public List<Pelicula> Get()
        {
            throw new NotImplementedException();
        }

        public Pelicula Get(int Id)
        {
            return peliculaContext.Peliculas.Where(p => p.Id == Id).FirstOrDefault();
        }
    }
}
