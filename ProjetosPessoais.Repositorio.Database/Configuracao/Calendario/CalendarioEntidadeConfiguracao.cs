using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetosPessoais.Dominio.Entidades.Calendario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Repositorio.Database.Configuracao.Calendario
{
    public class CalendarioEntidadeConfiguracao : IEntityTypeConfiguration<CompromissosEntidade>
    {
        public void Configure(EntityTypeBuilder<CompromissosEntidade> builder)
        {
            builder.ToTable("Calendario", "compromissos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Titulo).HasColumnType("varchar(55)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("varchar(55)").IsRequired();
            builder.Property(x => x.DataCompromisso).HasColumnType("date").IsRequired();
            builder.Property(x => x.Local).HasColumnType("varchar(55)").IsRequired();
        }
    }
}
