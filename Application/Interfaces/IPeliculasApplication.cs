
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPeliculasApplication
    {
        Task<List<Pelicula>> Get();
        Task<Pelicula> Get(int id);

        Task<Pelicula> Post(Pelicula pelicula);

        Task<bool> Delete(int id);
    }
}
