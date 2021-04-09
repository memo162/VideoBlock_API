using Models;
using Respository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<Reserva> Create(Reserva reserva)
        {
            return await _reservaRepository.Create(reserva);
        }

        public async Task Delete(int id)
        {
            await _reservaRepository.Delete(id);
        }

        public async Task<List<Reserva>> Get()
        {
            return await _reservaRepository.Get();
        }

        public async Task<Reserva> Get(int id)
        {
            return await _reservaRepository.Get(id);
        }

        public async Task<Reserva> Update(Reserva reserva)
        {
            return await _reservaRepository.Update(reserva);
        }
    }
}
