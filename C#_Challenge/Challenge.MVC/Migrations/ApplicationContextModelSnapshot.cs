﻿// <auto-generated />
using System;
using Challenge.MVC.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Challenge.MVC.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Challenge.MVC.Models.ClienteEntity", b =>
                {
                    b.Property<string>("cpf_cnpj")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("tipoPlano")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("usuarioidUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("cpf_cnpj");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("tb_Cliente");
                });

            modelBuilder.Entity("Challenge.MVC.Models.ConsultaEntity", b =>
                {
                    b.Property<string>("idConsulta")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("clientecpf_cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTime>("dateConsulta")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("dentistacpf_cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("tipoConsulta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<double>("valorMedioConsulta")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("idConsulta");

                    b.HasIndex("clientecpf_cnpj");

                    b.HasIndex("dentistacpf_cnpj");

                    b.ToTable("tb_Consulta");
                });

            modelBuilder.Entity("Challenge.MVC.Models.DentistaEntity", b =>
                {
                    b.Property<string>("cpf_cnpj")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("alvaraFuncionamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)");

                    b.Property<string>("cepClinica")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("nomeClinica")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("siteRedesSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("tipoClinica")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("usuarioidUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("cpf_cnpj");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("tb_Dentista");
                });

            modelBuilder.Entity("Challenge.MVC.Models.UsuarioEntity", b =>
                {
                    b.Property<string>("idUsuario")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<DateTime>("dataNascimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("idUsuario");

                    b.ToTable("tb_Usuario");
                });

            modelBuilder.Entity("Challenge.MVC.Models.ClienteEntity", b =>
                {
                    b.HasOne("Challenge.MVC.Models.UsuarioEntity", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioidUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Challenge.MVC.Models.ConsultaEntity", b =>
                {
                    b.HasOne("Challenge.MVC.Models.ClienteEntity", "cliente")
                        .WithMany("consultas")
                        .HasForeignKey("clientecpf_cnpj")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Challenge.MVC.Models.DentistaEntity", "dentista")
                        .WithMany("consultas")
                        .HasForeignKey("dentistacpf_cnpj")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("dentista");
                });

            modelBuilder.Entity("Challenge.MVC.Models.DentistaEntity", b =>
                {
                    b.HasOne("Challenge.MVC.Models.UsuarioEntity", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioidUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Challenge.MVC.Models.ClienteEntity", b =>
                {
                    b.Navigation("consultas");
                });

            modelBuilder.Entity("Challenge.MVC.Models.DentistaEntity", b =>
                {
                    b.Navigation("consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
