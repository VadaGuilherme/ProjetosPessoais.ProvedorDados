using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Dominio.Entidades.ContasPagar;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.ContasPagar;
using ProjetosPessoais.Repositorio.Database.Contexto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetosPessoais.Repositorio.Database.Repositorios.ContasPagar
{
    public class BancosRepositorio : RepositorioBase<BancosEntidade>, IBancosRepositorio
    {
        public BancosRepositorio(ProjetosPessoaisContexto context) : base(context) { }

        public async Task<List<BancosEntidade>> ListarTodosBancosAsync() =>
            await NoTracking()
            .ToListAsync();
    }
}
