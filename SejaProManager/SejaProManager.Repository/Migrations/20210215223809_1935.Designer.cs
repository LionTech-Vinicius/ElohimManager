﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SejaProManager.Repository.Context;

namespace SejaProManager.Repository.Migrations
{
    [DbContext(typeof(SejaProManagerContext))]
    [Migration("20210215223809_1935")]
    partial class _1935
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Congregacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DtFundacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("NomeResp")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("T_CONGREGACAO");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CongregacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CongregacaoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("T_CONTATO");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("Cep")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4");

                    b.Property<string>("Cidade")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("Complemento")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<int?>("CongregacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CongregacaoId")
                        .IsUnique();

                    b.HasIndex("PessoaId");

                    b.ToTable("T_ENDERECO");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GrauInstrucao")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("Naturalidade")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("NomeMae")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("NomePai")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("Rg")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("RgEmissao")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("Sexo")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("T_PESSOA");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("varchar CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar CHARACTER SET utf8mb4");

                    b.Property<string>("Perfil")
                        .HasColumnType("varchar CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Membro", b =>
                {
                    b.HasBaseType("SejaProManager.Domains.Entidades.Pessoa");

                    b.Property<string>("AtividadeProfissional")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<bool>("BatismoComES")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CargoOcupado")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<int>("CongregacaoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DtBatismo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtCasamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtRecebido")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EstadoCivil")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("IgrejaProcedencia")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("LiderFamiliar")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("Motivo")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("NomeConjuge")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("NomeIgrejaBat")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4");

                    b.Property<string>("Profissao")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<int>("QtdFilhos")
                        .HasColumnType("int");

                    b.Property<bool>("RecebidoPorAclamacao")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("RecebidoPorCarta")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TempoOcupado")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.HasIndex("CongregacaoId");

                    b.ToTable("T_MEMBRO");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Contato", b =>
                {
                    b.HasOne("SejaProManager.Domains.Entidades.Congregacao", "Congregacao")
                        .WithMany("Contatos")
                        .HasForeignKey("CongregacaoId");

                    b.HasOne("SejaProManager.Domains.Entidades.Pessoa", "Pessoa")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaId");

                    b.Navigation("Congregacao");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Endereco", b =>
                {
                    b.HasOne("SejaProManager.Domains.Entidades.Congregacao", "Congregacao")
                        .WithOne("Endereco")
                        .HasForeignKey("SejaProManager.Domains.Entidades.Endereco", "CongregacaoId");

                    b.HasOne("SejaProManager.Domains.Entidades.Pessoa", "Pessoa")
                        .WithMany("Endereco")
                        .HasForeignKey("PessoaId");

                    b.Navigation("Congregacao");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Membro", b =>
                {
                    b.HasOne("SejaProManager.Domains.Entidades.Congregacao", "Congregacao")
                        .WithMany("Membros")
                        .HasForeignKey("CongregacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SejaProManager.Domains.Entidades.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("SejaProManager.Domains.Entidades.Membro", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Congregacao");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Congregacao", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("Endereco");

                    b.Navigation("Membros");
                });

            modelBuilder.Entity("SejaProManager.Domains.Entidades.Pessoa", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
