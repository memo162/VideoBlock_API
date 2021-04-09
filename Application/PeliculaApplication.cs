
using Application.Interfaces;
using Models;
using Services;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class PeliculaApplication : IPeliculasApplication
    {

        public readonly IPeliculaService _peliculaService;

        public PeliculaApplication(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        public async Task<List<Pelicula>> Get()
        {
            return await _peliculaService.Get();
        }

        public async Task<Pelicula> Get(int id)
        {
            return await _peliculaService.Get(id);
        }

        public async Task<Pelicula> Post(Pelicula pelicula)
        {
            if (pelicula.Id == 0) 
            {
                return await _peliculaService.Create(pelicula);
            }
            else
            {
                return await _peliculaService.Update(pelicula);
            }
        }

        public async Task Delete(int id) 
        {
            await _peliculaService.Delete(id);
        }
    }
}
