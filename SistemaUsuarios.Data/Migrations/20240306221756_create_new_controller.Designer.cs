﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaUsuarios.Data.Contexts;

#nullable disable

namespace SistemaUsuarios.Data.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20240306221756_create_new_controller")]
    partial class create_new_controller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaUsuarios.Data.Entities.Historico", b =>
                {
                    b.Property<Guid>("IdHistorico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDHISTORICO");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORA");

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("DETALHES");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDUSUARIO");

                    b.Property<string>("Operacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("OPERACAO");

                    b.HasKey("IdHistorico");

                    b.HasIndex("IdUsuario");

                    b.ToTable("HISTORICO", (string)null);
                });

            modelBuilder.Entity("SistemaUsuarios.Data.Entities.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDUSUARIO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACRIACAO");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAULTIMAALTERACAO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SENHA");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("USUARIO", (string)null);
                });

            modelBuilder.Entity("SistemaUsuarios.Data.Entities.Historico", b =>
                {
                    b.HasOne("SistemaUsuarios.Data.Entities.Usuario", "Usuario")
                        .WithMany("Historicos")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaUsuarios.Data.Entities.Usuario", b =>
                {
                    b.Navigation("Historicos");
                });
#pragma warning restore 612, 618
        }
    }
}
