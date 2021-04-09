using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioApplication
    {
        Task<List<Usuario>> Get();
        Task<Usuario> Get(int id);
        Task<Usuario> Post(Usuario usuario);
        Task Delete(int id);
    }
}
