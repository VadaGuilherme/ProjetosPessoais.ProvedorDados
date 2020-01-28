using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Entidades
{
    public class EntidadeBase
    {
        protected EntidadeBase() => Guid = Guid.NewGuid();

        public int Id { get; protected set; }

        public Guid Guid { get; protected set; }
        public bool ENovo => Id == 0;
    }
}
