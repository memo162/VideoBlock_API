﻿
using Models;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPeliculasApplication
    {
        List<Pelicula> Get();
        Pelicula Get(int Id);
    }
}
