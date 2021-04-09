using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRolApplication
    {
        Task<List<Rol>> Get();
        Task<Rol> Get(int id);
        Task<Rol> Post(Rol rol);
        Task Delete(int id);
    }
}
