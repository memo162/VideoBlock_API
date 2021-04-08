
using Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IPeliculaService
    {
        List<Pelicula> Get();
        Pelicula Get(int Id);
    }
}
