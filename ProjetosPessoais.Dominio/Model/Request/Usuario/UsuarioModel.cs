using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Dominio.Model.Request.Usuario
{
    public class UsuarioModel
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
