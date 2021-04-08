
using Application.Interfaces;
using Models;
using Services;
using Services.Interfaces;
using System.Collections.Generic;

namespace Application
{
    public class PeliculaApplication : IPeliculasApplication
    {

        public readonly IPeliculaService _peliculaService;

        public PeliculaApplication(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        public List<Pelicula> Get()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula Get(int Id)
        {
            return _peliculaService.Get(Id);
        }
    }
}
