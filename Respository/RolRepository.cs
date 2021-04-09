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
    public class RolRepository : IRolRepository
    {
        private readonly IRepositoryDbProvider _reposirotyDbProvider;

        public RolRepository(IRepositoryDbProvider reposirotyDbProvider)
        {
            _reposirotyDbProvider = reposirotyDbProvider;
        }

        public async Task<List<Rol>> Get()
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Roles.ToListAsync();
            }
        }

        public async Task<Rol> Get(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Roles.Where(p => p.Id == id).FirstOrDefaultAsync();
            }
        }

        public async Task<Rol> Create(Rol rol)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                rol.FechaCreacion = DateTime.UtcNow;
                await dbContext.Roles.AddAsync(rol);
                await dbContext.SaveChangesAsync();

                return rol;
            }
        }

        public async Task<Rol> Update(Rol rol)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityRol = await dbContext.Roles.Where(p => p.Id == rol.Id).FirstOrDefaultAsync();
                if (entityRol == null)
                {
                    throw new NotFoundDBException($"Entity Rol with Id: {rol.Id} not found");
                }
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                rol.FechaActualizacion = DateTime.UtcNow;

                dbContext.Entry(rol).State = EntityState.Modified;
                dbContext.Entry(rol).Property(x => x.FechaCreacion).IsModified = false;
                await dbContext.SaveChangesAsync();
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Roles.Where(p => p.Id == rol.Id).FirstOrDefaultAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityRol = await dbContext.Roles.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (entityRol == null)
                {
                    throw new NotFoundDBException($"Entity Rol with Id: {id} not found");
                }

                entityRol.Eliminado = true;
                dbContext.Update(entityRol);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}

