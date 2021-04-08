using Models;
using Respository;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly PeliculaRepository _peliculaRepository;
        public PeliculaService(PeliculaRepository peliculaRepository) 
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
