using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Repositorio.Database.Configuracao.Calendario;
using ProjetosPessoais.Repositorio.Database.Configuracao.ContasPagar;
using ProjetosPessoais.Repositorio.Database.Configuracao.Usuarios;
using ProjetosPessoais.Repositorio.Database.Seed;

namespace ProjetosPessoais.Repositorio.Database.Contexto
{
    public class ProjetosPessoaisContexto : DbContext
    {
        public ProjetosPessoaisContexto(DbContextOptions<ProjetosPessoaisContexto> options) : base(options) => Database.Migrate();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BancosEntidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new CalendarioEntidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new UsuariosEntidadeConfiguracao());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
