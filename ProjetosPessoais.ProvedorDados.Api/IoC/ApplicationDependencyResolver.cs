using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Calendario;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.ContasPagar;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Transacoes;
using ProjetosPessoais.Dominio.Repositorios.Interfaces.Usuario;
using ProjetosPessoais.Dominio.Servicos.Calendario;
using ProjetosPessoais.Dominio.Servicos.ContasPagar;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Calendario;
using ProjetosPessoais.Dominio.Servicos.Interfaces.ContasPagar;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Usuario;
using ProjetosPessoais.Dominio.Servicos.Usuario;
using ProjetosPessoais.Repositorio.Database.Contexto;
using ProjetosPessoais.Repositorio.Database.Repositorios.Calendario;
using ProjetosPessoais.Repositorio.Database.Repositorios.ContasPagar;
using ProjetosPessoais.Repositorio.Database.Repositorios.Usuario;
using ProjetosPessoais.Repositorio.Database.Transacoes;

namespace ProjetosPessoais.ProvedorDados.API.IoC
{
    public static class ApplicationDependencyResolver
    {
        public static void AddDependencies(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddDbContext<ProjetosPessoaisContexto>(x => x.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                y => y.MigrationsHistoryTable("HistoryMigrations", "projetospessoais").UseNetTopologySuite()
            ));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region [Repositorios]
            services.AddScoped<IBancosRepositorio, BancosRepositorio>();
            services.AddScoped<ICompromissoRepositorio, CompromissoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            #endregion

            #region [Servicos]
            services.AddScoped<IBancosServico, BancosServico>();
            services.AddScoped<ICompromissoServico, CompromissoServico>();
            services.AddScoped<IUsuarioServico, UsuarioServico>();
            #endregion
        }
    }
}
