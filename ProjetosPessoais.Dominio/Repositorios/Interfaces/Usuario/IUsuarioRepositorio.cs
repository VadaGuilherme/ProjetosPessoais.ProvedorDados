using ProjetosPessoais.Dominio.Entidades.Usuario;
using ProjetosPessoais.Dominio.Model.Request.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Repositorios.Interfaces.Usuario
{
    public interface IUsuarioRepositorio
    {
        void Add(UsuariosEntidade user);
        Task<UsuariosEntidade> GetAll();
        UsuariosEntidade Autenticar(string usuario, string senha);
        Task<List<UsuariosEntidade>> Find(long id);
        void Remove(long id);
        void Update(UsuariosEntidade user);
    }
}
