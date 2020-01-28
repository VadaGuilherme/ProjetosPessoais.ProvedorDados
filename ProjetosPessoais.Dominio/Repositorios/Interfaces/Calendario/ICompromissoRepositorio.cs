using ProjetosPessoais.Dominio.Entidades.Calendario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Repositorios.Interfaces.Calendario
{
    public interface ICompromissoRepositorio
    {
        Task<List<CompromissosEntidade>> ListarTodosCompromissosAsync();
        Task<List<CompromissosEntidade>> ListarCompromissosComFiltroAsync(DateTime dataAtual);
    }
}
