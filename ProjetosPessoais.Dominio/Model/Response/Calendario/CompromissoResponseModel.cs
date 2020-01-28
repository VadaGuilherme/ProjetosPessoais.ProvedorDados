using ProjetosPessoais.Dominio.Entidades.Calendario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Model.Response.Calendario
{
    public class CompromissoResponseModel
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCompromisso { get; set; }
        public string Local { get; set; }

        //internal static List<CompromissoResponseModel> Criar(List<CompromissosEntidade> listCompromisso)
        //{
        //    List<CompromissoResponseModel> compromissoResponse = new List<CompromissoResponseModel>();
        //    foreach (var compromisso in listCompromisso)
        //    {
        //        compromissoResponse.Add(new CompromissoResponseModel
        //        {
        //            Id = compromisso.Id,
        //            Guid = compromisso.Guid,
        //            Titulo = compromisso.Titulo,
        //            Descricao = compromisso.Descricao,
        //            DataCompromisso = compromisso.DataCompromisso,
        //            Local = compromisso.Local
        //        });
        //    }
        //    return compromissoResponse;
        //}

        public static explicit operator CompromissoResponseModel(CompromissosEntidade entidade)
        {
            if (entidade == null)
                return null;

            return new CompromissoResponseModel
            {
                Id = entidade.Id,
                Guid = entidade.Guid,
                Titulo = entidade.Titulo,
                Descricao = entidade.Descricao,
                Local = entidade.Local,
                DataCompromisso = entidade.DataCompromisso,
            };
        }
    }
}
