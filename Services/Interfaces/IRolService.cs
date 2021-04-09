using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{ 
    public interface IRolService
    {
        Task<List<Rol>> Get();
        Task<Rol> Get(int id);
        Task<Rol> Create(Rol rol);
        Task<Rol> Update(Rol rol);
        Task Delete(int id);
    }
}
