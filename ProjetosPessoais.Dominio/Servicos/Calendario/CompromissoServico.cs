using ProjetosPessoais.Dominio.Entidades.Calendario;
using ProjetosPessoais.Dominio.Model.Response.Calendario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Calendario;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Calendario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.Calendario
{
    public class CompromissoServico : ICompromissoServico
    {
        private readonly ICompromissoRepositorio _calendarioRepositorio;

        public CompromissoServico(ICompromissoRepositorio calendarioRepositorio)
        {
            _calendarioRepositorio = calendarioRepositorio;
        }

        public async Task<ResponseMessage> ListarCompromissosComFiltro(DateTime dataAtual)
        {
            try
            {
                var resposta = (await _calendarioRepositorio.ListarCompromissosComFiltroAsync(dataAtual)).Select(x => (CompromissoResponseModel)x);
                return ResponseMessage.Ok(resposta);
            }
            catch (Exception ex)
            {
                return ResponseMessage.ErroValidacao(null, ex.Message);
            }
        }

        public async Task<ResponseMessage> ListarTodosCompromissos()
        {
            try
            {
                var resposta = (await _calendarioRepositorio.ListarTodosCompromissosAsync()).Select(x => (CompromissoResponseModel)x);
                return ResponseMessage.Ok(resposta);
            }
            catch (Exception ex)
            {
                return ResponseMessage.ErroValidacao(null, ex.Message);
            }
        }
    }
}
