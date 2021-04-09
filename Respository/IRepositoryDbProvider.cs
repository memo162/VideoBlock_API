using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public interface IRepositoryDbProvider
    {
        RepositoryDbContext GetDbContext();
    }
}
