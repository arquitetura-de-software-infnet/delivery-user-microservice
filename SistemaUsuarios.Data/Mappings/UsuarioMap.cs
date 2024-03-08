using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaUsuarios.Data.Entities;

namespace SistemaUsuarios.Data.Mappings
{
    /// <summary>
    /// Classe para mapeamento da entidade usuario
    /// </summary>
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        //método para realizar o mapeamento da entidade
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //nome da tabela
            builder.ToTable("USUARIO");

            //chave primaria
            builder.HasKey(u => u.IdUsuario);

            //mapeamento dos campos da tabela
            builder.Property(u => u.IdUsuario)
                .HasColumnName("IDUSUARIO")
                .IsRequired();

            builder.Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsRequired();

            //Definindo o campo email como unico
            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Senha)
                .HasColumnName("SENHA")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.DataCriacao)
                .HasColumnName("DATACRIACAO")
                .IsRequired();

            builder.Property(u => u.DataUltimaAlteracao)
                .HasColumnName("DATAULTIMAALTERACAO")
                .IsRequired();
        }
    }
}