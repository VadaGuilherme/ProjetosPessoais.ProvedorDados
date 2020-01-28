using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Dominio.Entidades.Calendario;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Calendario;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.ContasPagar;
using ProjetosPessoais.Repositorio.Database.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Repositorio.Database.Repositorios.Calendario
{
    public class CompromissoRepositorio : RepositorioBase<CompromissosEntidade>, ICompromissoRepositorio
    {
        public CompromissoRepositorio(ProjetosPessoaisContexto context) : base(context) { }

        public async Task<List<CompromissosEntidade>> ListarTodosCompromissosAsync() =>
            await NoTracking()
            .ToListAsync();

        public async Task<List<CompromissosEntidade>> ListarCompromissosComFiltroAsync(DateTime dataAtual) =>
            await NoTracking()
            .Where(x => x.DataCompromisso >= dataAtual)
            .ToListAsync();
    }
}
