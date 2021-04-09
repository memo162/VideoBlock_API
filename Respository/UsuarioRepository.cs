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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IRepositoryDbProvider _reposirotyDbProvider;

        public UsuarioRepository(IRepositoryDbProvider reposirotyDbProvider)
        {
            _reposirotyDbProvider = reposirotyDbProvider;
        }

        public async Task<List<Usuario>> Get()
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Usuarios.Include(usuario => usuario.Rol).ToListAsync();
            }
        }

        public async Task<Usuario> Get(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Usuarios.Where(p => p.Id == id).Include(usuario => usuario.Rol).FirstOrDefaultAsync();
            }
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                usuario.FechaCreacion = DateTime.UtcNow;
                await dbContext.Usuarios.AddAsync(usuario);
                await dbContext.SaveChangesAsync();

                return usuario;
            }
        }

        public async Task<Usuario> Update(Usuario usuario)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityUsuario = await dbContext.Usuarios.Where(p => p.Id == usuario.Id).FirstOrDefaultAsync();
                if (entityUsuario == null)
                {
                    throw new NotFoundDBException($"Entity Usuario with Id: {usuario.Id} not found");
                }
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                usuario.FechaActualizacion = DateTime.UtcNow;

                dbContext.Entry(usuario).State = EntityState.Modified;
                dbContext.Entry(usuario).Property(x => x.FechaCreacion).IsModified = false;
                await dbContext.SaveChangesAsync();
            }

            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                return await dbContext.Usuarios.Where(p => p.Id == usuario.Id).FirstOrDefaultAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (var dbContext = _reposirotyDbProvider.GetDbContext())
            {
                var entityUsuario = await dbContext.Usuarios.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (entityUsuario == null)
                {
                    throw new NotFoundDBException($"Entity Usuario with Id: {id} not found");
                }

                entityUsuario.Eliminado = true;
                dbContext.Update(entityUsuario);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
