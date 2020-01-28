using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Dominio.Entidades;
using ProjetosPessoais.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Repositorio.Database.Repositorios
{
    public class RepositorioBase<T> : IRepositorio<T, Guid> where T : EntidadeBase
    {
        public readonly DbContext Context;
        public readonly DbSet<T> DbSet;

        public RepositorioBase(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public virtual T Salvar(T entity)
        {
            if (entity.ENovo)
                DbSet.Add(entity);
            else
                DbSet.Update(entity);

            return entity;
        }

        public virtual async Task DeletarAsync(Guid identifier)
        {
            var ett = await NoTracking().FirstOrDefaultAsync(x => x.Guid == identifier);

            DbSet.Remove(ett);
        }

        public virtual async Task<bool> ExisteAsync(Guid guid)
        {
            return await DbSet.AnyAsync(x => x.Guid == guid);
        }

        public virtual async Task<T> ObterPorIdentificadorAsync(Guid guid)
        {
            return await NoTracking().FirstOrDefaultAsync(x => x.Guid == guid);
        }

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await NoTracking().ToListAsync();
        }

        public virtual IQueryable<T> NoTracking()
        {
            return DbSet.AsNoTracking();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
