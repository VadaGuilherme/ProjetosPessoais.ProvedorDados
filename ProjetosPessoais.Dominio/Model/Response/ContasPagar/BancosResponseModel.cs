using ProjetosPessoais.Dominio.Entidades.ContasPagar;
using System;
using System.Collections.Generic;

namespace ProjetosPessoais.Dominio.Model.Response.ContasPagar
{
    public class BancosResponseModel
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string CodBanco { get; set; }
        public string Nome { get; set; }

        internal static List<BancosResponseModel> Criar(List<BancosEntidade> listBancos)
        {
            List<BancosResponseModel> bancosResponse = new List<BancosResponseModel>();
            foreach (var banco in listBancos)
            {
                bancosResponse.Add(new BancosResponseModel
                {
                    Id = banco.Id,
                    Guid = banco.Guid,
                    Nome = banco.Descricao,
                    CodBanco = banco.CodBanco
                   
                });
            }
            return bancosResponse;
        }
    }
}
