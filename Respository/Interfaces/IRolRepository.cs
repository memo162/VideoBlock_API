using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Respository.Interfaces
{
    public interface IRolRepository
    {
        Task<List<Rol>> Get();
        Task<Rol> Get(int id);
        Task<Rol> Create(Rol rol);
        Task<Rol> Update(Rol rol);
        Task Delete(int id);
    }
}
