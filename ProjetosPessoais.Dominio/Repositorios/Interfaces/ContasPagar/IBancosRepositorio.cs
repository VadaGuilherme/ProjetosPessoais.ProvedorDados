using ProjetosPessoais.Dominio.Entidades.ContasPagar;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetosPessoais.Dominio.Repositorios.Interfaces.ContasPagar
{
    public interface IBancosRepositorio
    {
        Task<List<BancosEntidade>>ListarTodosBancosAsync();
    }
}
