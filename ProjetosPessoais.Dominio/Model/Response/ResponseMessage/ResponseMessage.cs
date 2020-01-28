using ProjetosPessoais.Dominio.Enums.MessageResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Model.Response.ResponseMessage
{
    public class ResponseMessage
    {
        public bool Sucesso { get; set; }
        public StatusCodeEnum CodigoStatus { get; set; }
        public object Dado { get; set; }
        public string Mensagem { get; set; }
        public IEnumerable<string> Erros { get; set; }

        public static ResponseMessage Ok(object dado) =>
            Criar(true, StatusCodeEnum.Ok, dado, null, null);

        public static ResponseMessage ErroValidacao(object dado, string erro) =>
            CriarComUnicoErro(false, StatusCodeEnum.ErroValidacao, dado, ResponseMessageError.RequisicaoIncompletaComErros, erro);

        private static ResponseMessage Criar(bool eSucesso, StatusCodeEnum codigoStatus, object dado, string mensagem, IEnumerable<string> erros)
        {
            return new ResponseMessage
            {
                Sucesso = eSucesso,
                CodigoStatus = codigoStatus,
                Mensagem = mensagem,
                Dado = dado,
                Erros = erros
            };
        }

        private static ResponseMessage CriarComUnicoErro(bool eSucesso, StatusCodeEnum codigoStatus, object dado, string mensagem, string erro) =>
            Criar(eSucesso, codigoStatus, dado, mensagem, new List<string> { erro });
    }
}
