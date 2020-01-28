using ProjetosPessoais.Dominio.Entidades.Calendario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.Interfaces.Calendario
{
    public interface ICompromissoServico
    {
        Task<ResponseMessage> ListarTodosCompromissos();
        Task<ResponseMessage> ListarCompromissosComFiltro(DateTime dataAtual);
    }
}
