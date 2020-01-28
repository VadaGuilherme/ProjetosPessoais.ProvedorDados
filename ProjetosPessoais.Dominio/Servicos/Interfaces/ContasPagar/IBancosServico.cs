using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.Interfaces.ContasPagar
{
    public interface IBancosServico
    {
        Task<ResponseMessage> ListarTodosBancos();
    }
}
