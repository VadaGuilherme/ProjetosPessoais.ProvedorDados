using Microsoft.AspNetCore.Mvc;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Servicos.Interfaces.ContasPagar;
using System.Threading.Tasks;

namespace ProjetosPessoais.ProvedorDados.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasPagarController : ControllerBase
    {
        private readonly IBancosServico _contasPagarServico;

        public ContasPagarController(IBancosServico contasPagar)
        {
            _contasPagarServico = contasPagar;
        }

        [HttpGet("ListarTodosBancos")]
        public async Task<ResponseMessage> ListarTodosBancos() =>
            await _contasPagarServico.ListarTodosBancos();
    }
}