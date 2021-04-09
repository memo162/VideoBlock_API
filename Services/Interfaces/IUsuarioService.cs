using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Get();
        Task<Usuario> Get(int id);
        Task<Usuario> Create(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        Task Delete(int id);
    }
}
