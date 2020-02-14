using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Entidades.Usuario
{
    public class UsuariosEntidade : EntidadeBase
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
