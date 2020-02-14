using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetosPessoais.Dominio.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetosPessoais.Repositorio.Database.Configuracao.Usuarios
{
    class UsuariosEntidadeConfiguracao : IEntityTypeConfiguration<UsuariosEntidade>
    {
        public void Configure(EntityTypeBuilder<UsuariosEntidade> builder)
        {
            builder.ToTable("Usuarios", "autenticacao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).HasColumnType("varchar(55)").IsRequired();
            builder.Property(x => x.Senha).HasColumnType("varchar(55)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(55)").IsRequired();
        }
    }
}
