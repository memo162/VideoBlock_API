using Models;
using Respository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public async Task<Pelicula> Create(Pelicula pelicula)
        {
            return await _peliculaRepository.Create(pelicula);
        }

        public async Task Delete(int id)
        {
            await _peliculaRepository.Delete(id);
        }

        public async Task<List<Pelicula>> Get()
        {
            return await _peliculaRepository.Get();
        }

        public async Task<Pelicula> Get(int id)
        {
           return await _peliculaRepository.Get(id);
        }

        public async Task<Pelicula> Update(Pelicula pelicula)
        {
            return await _peliculaRepository.Update(pelicula);
        }
    }
}
