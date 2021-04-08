using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Respository.Interfaces
{
    public interface IPeliculaRepository
    {
        Task<List<Pelicula>> Get();
        Task<Pelicula> Get(int id);
        Task<Pelicula> Create(Pelicula pelicula);
        Task<Pelicula> Update(Pelicula pelicula);
        Task Delete(int id);
    }
}
