using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public interface IReposirotyDbProvider
    {
        RepositoryDbContext GetDbContext();
    }
}
