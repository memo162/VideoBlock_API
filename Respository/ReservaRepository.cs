using Microsoft.EntityFrameworkCore;
using Models;
using Models.Exceptions;
using Respository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Respository
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly IRepositoryDbProvider _reposirotyDbProvider;

        public ReservaRepository(IRepositoryDbProvider reposirotyDbProvider)
        {
            _reposirotyDbProvider = reposirotyDbProvider;
        }

        public async Task<List<Reserva>> Get()
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Reservas.Include(reserva => reserva.Pelicula).Include(reserva => reserva.Usuario).ToListAsync();
            }
        }

        public async Task<Reserva> Get(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Reservas.Where(p => p.Id == id).Include(reserva => reserva.Pelicula).Include(reserva => reserva.Usuario).FirstOrDefaultAsync();
            }
        }

        public async Task<List<Reserva>> Get(Usuario usuario)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Reservas.Where(p => p.UsuarioId == usuario.Id && p.Cerrada == false && p.Eliminado == false)
                    .Include(reserva => reserva.Pelicula).Include(reserva => reserva.Usuario).ToListAsync();
            }
        }

        public async Task<Reserva> Create(Reserva reserva)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                reserva.FechaCreacion = DateTime.UtcNow;
                await dbContext.Reservas.AddAsync(reserva);
                await dbContext.SaveChangesAsync();

                return reserva;
            }
        }

        public async Task<Reserva> Update(Reserva reserva)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityReserva = await dbContext.Reservas.Where(p => p.Id == reserva.Id).FirstOrDefaultAsync();
                if (entityReserva == null)
                {
                    throw new NotFoundDBException($"Entity Reserva with Id: {reserva.Id} not found");
                }

                entityReserva.Eliminado = true;
                dbContext.Update(entityReserva);
                await dbContext.SaveChangesAsync();
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                reserva.FechaActualizacion = DateTime.UtcNow;

                dbContext.Entry(reserva).State = EntityState.Modified;
                dbContext.Entry(reserva).Property(x => x.FechaCreacion).IsModified = false;
                await dbContext.SaveChangesAsync();
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Reservas.Where(p => p.Id == reserva.Id).FirstOrDefaultAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityReserva = await dbContext.Reservas.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (entityReserva == null)
                {
                    throw new NotFoundDBException($"Entity Reserva with Id: {id} not found");
                }

                entityReserva.Eliminado = true;
                dbContext.Update(entityReserva);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
