using Models;
using System.Collections.Generic;

namespace Respository.Interfaces
{
    public interface IPeliculaReposiroty
    {
        List<Pelicula> Get();
        Pelicula Get(int Id);
    }
}
