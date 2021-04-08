using Models;
using System.Collections.Generic;

namespace Respository.Interfaces
{
    public interface IPeliculaRepository
    {
        List<Pelicula> Get();
        Pelicula Get(int Id);
    }
}
