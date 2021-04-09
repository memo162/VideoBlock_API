using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IReservaService
    {
        Task<List<Reserva>> Get();
        Task<Reserva> Get(int id);
        Task<Reserva> Create(Reserva reserva);
        Task<Reserva> Update(Reserva reserva);
        Task Delete(int id);
    }
}
