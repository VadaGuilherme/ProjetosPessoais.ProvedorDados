using ProjetosPessoais.Dominio.Model.Request.ContasPagar;
using System;

namespace ProjetosPessoais.Dominio.Entidades.ContasPagar
{
    public class BancosEntidade : EntidadeBase
    {
        public string CodBanco { get; set; }
        public string Descricao { get; set; }

        public BancosEntidade()
        {

        }

        public static BancosEntidade Criar(int id, Guid Guid, string codBanco, string descricao) => new BancosEntidade()
        {
            Id = id,
            Guid = Guid,
            CodBanco = codBanco,
            Descricao = descricao,
        };
    }
}
