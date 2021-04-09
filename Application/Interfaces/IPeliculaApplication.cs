using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPeliculaApplication
    {
        Task<List<Pelicula>> Get();
        Task<Pelicula> Get(int id);
        Task<Pelicula> Post(Pelicula pelicula);
        Task Delete(int id);
    }
}
