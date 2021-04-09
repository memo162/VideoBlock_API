using Application.Interfaces;
using Models;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class ReservaApplication : IReservaApplication
    {
        public readonly IReservaService _reservaService;

        public ReservaApplication(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public async Task<List<Reserva>> Get()
        {
            return await _reservaService.Get();
        }

        public async Task<Reserva> Get(int id)
        {
            return await _reservaService.Get(id);
        }

        public async Task<Reserva> Post(Reserva reserva)
        {
            if (reserva.Id == 0)
            {
                return await _reservaService.Create(reserva);
            }
            else
            {
                return await _reservaService.Update(reserva);
            }
        }

        public async Task Delete(int id)
        {
            await _reservaService.Delete(id);
        }
    }
}
