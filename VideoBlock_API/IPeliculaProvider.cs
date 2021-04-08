using Models;
using System.Collections.Generic;

namespace VideoBlock_API
{
    public interface IPeliculaProvider
    {
        List<Pelicula> Get();
        Pelicula Get(int Id);
    }
}
