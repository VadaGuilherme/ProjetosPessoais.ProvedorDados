using ProjetosPessoais.Dominio.Model.Request.Usuario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.Interfaces.Usuario
{
    public interface IUsuarioServico
    {
        Task<ResponseMessage> GetAll();
        object Find(long id);
        object Autenticar(string nome, string senha);
        void Add(UsuarioModel usuario);
        void Update(object usuario);
        void Remove(long id);
    }
}
