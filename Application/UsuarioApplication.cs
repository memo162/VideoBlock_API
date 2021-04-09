using Application.Interfaces;
using Models;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        public readonly IUsuarioService _usuarioService;

        public UsuarioApplication(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<List<Usuario>> Get()
        {
            return await _usuarioService.Get();
        }

        public async Task<Usuario> Get(int id)
        {
            return await _usuarioService.Get(id);
        }

        public async Task<Usuario> Post(Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                return await _usuarioService.Create(usuario);
            }
            else
            {
                return await _usuarioService.Update(usuario);
            }
        }

        public async Task Delete(int id)
        {
            await _usuarioService.Delete(id);
        }
    }
}
