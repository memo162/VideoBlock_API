using Models;
using Respository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;
        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public List<Pelicula> Get()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula Get(int Id)
        {
           return _peliculaRepository.Get(Id);
        }
    }
}
