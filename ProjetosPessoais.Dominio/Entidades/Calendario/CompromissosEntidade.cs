using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Entidades.Calendario
{
    public class CompromissosEntidade : EntidadeBase
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCompromisso { get; set; }
        public string Local { get; set; }

        public CompromissosEntidade()
        {

        }

        public static CompromissosEntidade Criar(int id, Guid Guid, string titulo, string descricao, DateTime dataCompromisso, string local) => new CompromissosEntidade()
        {
            Id = id,
            Guid = Guid,
            Titulo = titulo,
            Descricao = descricao,
            DataCompromisso = dataCompromisso,
            Local = local
        };
    }
}
