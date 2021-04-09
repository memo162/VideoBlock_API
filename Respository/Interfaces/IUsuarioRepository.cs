using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Respository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> Get();
        Task<Usuario> Get(int id);
        Task<Usuario> Create(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        Task Delete(int id);
    }
}
