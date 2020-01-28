using ProjetosPessoais.Dominio.Repositorios.Interfaces.Transacoes;
using ProjetosPessoais.Repositorio.Database.Contexto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Repositorio.Database.Transacoes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjetosPessoaisContexto _context;

        public UnitOfWork(ProjetosPessoaisContexto context) => _context = context;

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public bool SaveChanges() => _context.SaveChanges() > 0;
        public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;
    }
}
