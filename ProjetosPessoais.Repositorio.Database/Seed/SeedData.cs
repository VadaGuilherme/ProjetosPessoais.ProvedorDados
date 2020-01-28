using Microsoft.EntityFrameworkCore;
using ProjetosPessoais.Dominio.Entidades.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Repositorio.Database.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder
                .Entity<BancosEntidade>()
                .HasData(
                    BancosEntidade.Criar(1, Guid.NewGuid(), "001", "Banco do Brasil S.A."),
                    BancosEntidade.Criar(2, Guid.NewGuid(), "341", "Itaú S.A"),
                    BancosEntidade.Criar(3, Guid.NewGuid(), "033", "Santander"),
                    BancosEntidade.Criar(4, Guid.NewGuid(), "237", "Banco Bradesco S.A."),
                    BancosEntidade.Criar(5, Guid.NewGuid(), "104", "Caixa Econômica Federal")
                );
        }
    }
}
