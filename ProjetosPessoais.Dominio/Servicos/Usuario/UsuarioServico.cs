using ProjetosPessoais.Dominio.Model.Request.Usuario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Usuario;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Usuario;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Servicos.Usuario
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public void Add(UsuarioModel usuario)
        {
            throw new System.NotImplementedException();
        }

        public object Autenticar(string nome, string senha)
        {
            throw new System.NotImplementedException();
        }

        public object Find(long id)
        {
            try
            {
                return _usuarioRepositorio.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ResponseMessage> GetAll()
        {
            try
            {
                var resposta = await _usuarioRepositorio.GetAll();
                return ResponseMessage.Ok(resposta);
            }
            catch (Exception ex)
            {
                return ResponseMessage.ErroValidacao(null, ex.Message);
            }
        }

        public void Remove(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(object usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
