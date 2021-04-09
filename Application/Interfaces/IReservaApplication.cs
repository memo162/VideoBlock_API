using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReservaApplication
    {
        Task<List<Reserva>> Get();
        Task<Reserva> Get(int id);
        Task<Reserva> Post(Reserva reserva);
        Task Delete(int id);
    }
}
