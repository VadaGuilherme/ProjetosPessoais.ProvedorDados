using ProjetosPessoais.Dominio.Model.Response.ContasPagar;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.ContasPagar;
using ProjetosPessoais.Dominio.Servicos.Interfaces.ContasPagar;
using System;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.ContasPagar
{
    public class BancosServico : IBancosServico
    {
        private readonly IBancosRepositorio _bancosRepositorio;

        public BancosServico(IBancosRepositorio bancosRepositorio)
        {
            _bancosRepositorio = bancosRepositorio;
        }
        public async Task<ResponseMessage> ListarTodosBancos()
        {
            try
            {
                return ResponseMessage.Ok(BancosResponseModel.Criar(await _bancosRepositorio.ListarTodosBancosAsync()));
            }
            catch (Exception ex)
            {
                return ResponseMessage.ErroValidacao(null, ex.Message);
            }
        }
    }
}
