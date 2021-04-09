using Models;
using Respository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public  class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
            return await _usuarioRepository.Create(usuario);
        }

        public async Task Delete(int id)
        {
            await _usuarioRepository.Delete(id);
        }

        public async Task<List<Usuario>> Get()
        {
            return await _usuarioRepository.Get();
        }

        public async Task<Usuario> Get(int id)
        {
            return await _usuarioRepository.Get(id);
        }

        public async Task<Usuario> Update(Usuario usuario)
        {
            return await _usuarioRepository.Update(usuario);
        }
    }
}
