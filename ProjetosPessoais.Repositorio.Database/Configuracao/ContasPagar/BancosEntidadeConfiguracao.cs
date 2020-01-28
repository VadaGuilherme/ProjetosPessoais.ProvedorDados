using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetosPessoais.Dominio.Entidades.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Repositorio.Database.Configuracao.ContasPagar
{
    public class BancosEntidadeConfiguracao : IEntityTypeConfiguration<BancosEntidade>
    {
        public void Configure(EntityTypeBuilder<BancosEntidade> builder)
        {
            builder.ToTable("Bancos", "contapagar");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CodBanco).HasColumnType("varchar(55)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("varchar(55)").IsRequired();
        }
    }
}
