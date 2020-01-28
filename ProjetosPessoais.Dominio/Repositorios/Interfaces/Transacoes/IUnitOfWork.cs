using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Repositorios.Interfaces.Transacoes
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
