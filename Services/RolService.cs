using Models;
using Respository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Services
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public async Task<Rol> Create(Rol rol)
        {
            return await _rolRepository.Create(rol);
        }

        public async Task Delete(int id)
        {
            await _rolRepository.Delete(id);
        }

        public async Task<List<Rol>> Get()
        {
            return await _rolRepository.Get();
        }

        public async Task<Rol> Get(int id)
        {
            return await _rolRepository.Get(id);
        }

        public async Task<Rol> Update(Rol rol)
        {
            return await _rolRepository.Update(rol);
        }
    }
}
