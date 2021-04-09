using Application.Interfaces;
using Models;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class RolApplication : IRolApplication
    {
        public readonly IRolService _rolService;

        public RolApplication(IRolService rolService)
        {
            _rolService = rolService;
        }

        public async Task<List<Rol>> Get()
        {
            return await _rolService.Get();
        }

        public async Task<Rol> Get(int id)
        {
            return await _rolService.Get(id);
        }

        public async Task<Rol> Post(Rol rol)
        {
            if (rol.Id == 0)
            {
                return await _rolService.Create(rol);
            }
            else
            {
                return await _rolService.Update(rol);
            }
        }

        public async Task Delete(int id)
        {
            await _rolService.Delete(id);
        }
    }
}
