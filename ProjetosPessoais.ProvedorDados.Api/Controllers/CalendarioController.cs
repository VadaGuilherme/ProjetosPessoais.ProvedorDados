using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Calendario;

namespace ProjetosPessoais.ProvedorDados.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarioController : Controller
    {
        private readonly ICompromissoServico _calendarioServico;

        public CalendarioController(ICompromissoServico calendario)
        {
            _calendarioServico = calendario;
        }

        [HttpGet("ListarCompromissos")]
        public async Task<ResponseMessage> ListarTodosCompromissos() =>
            await _calendarioServico.ListarTodosCompromissos();

        [HttpGet("ListarCompromissosComFiltro")]
        public async Task<ResponseMessage> ListarCompromissosComFiltro(DateTime dataAtual) =>
            await _calendarioServico.ListarCompromissosComFiltro(dataAtual);
    }
}
