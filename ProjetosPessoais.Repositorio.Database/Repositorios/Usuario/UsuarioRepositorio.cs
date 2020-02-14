using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Dominio.Entidades.Usuario;
using ProjetosPessoais.Dominio.Model.Request.Usuario;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Usuario;
using ProjetosPessoais.Repositorio.Database.Contexto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosPessoais.Repositorio.Database.Repositorios.Usuario
{
    public class UsuarioRepositorio : RepositorioBase<UsuariosEntidade>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProjetosPessoaisContexto context) : base(context) { }

        public void Add(UsuariosEntidade usuarioEntidade)
        {
            throw new System.NotImplementedException();
        }

        public UsuariosEntidade Autenticar(string usuario, string senha)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<UsuariosEntidade>> Find(long id) =>
            await NoTracking()
                .Where(x => x.Id == id)
                .ToListAsync();

        public async Task<UsuariosEntidade> GetAll() =>
            await NoTracking()
                .FirstOrDefaultAsync();

        public void Remove(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UsuariosEntidade usuarioEntidade)
        {
            throw new System.NotImplementedException();
        }
    }
}
