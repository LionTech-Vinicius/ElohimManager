using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SejaProManager.API.Models
{
    public partial class SejaProMangerContext : DbContext
    {
        public SejaProMangerContext()
        {
        }

        public SejaProMangerContext(DbContextOptions<SejaProMangerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PaAluno> PaAluno { get; set; }
        public virtual DbSet<PaAulas> PaAulas { get; set; }
        public virtual DbSet<PaCadastro> PaCadastro { get; set; }
        public virtual DbSet<PaEstadoCivil> PaEstadoCivil { get; set; }
        public virtual DbSet<PaLock> PaLock { get; set; }
        public virtual DbSet<PaMenu> PaMenu { get; set; }
        public virtual DbSet<PaMenuItem> PaMenuItem { get; set; }
        public virtual DbSet<PaOpcao> PaOpcao { get; set; }
        public virtual DbSet<PaPerfil> PaPerfil { get; set; }
        public virtual DbSet<PaPessoa> PaPessoa { get; set; }
        public virtual DbSet<PaProfessor> PaProfessor { get; set; }
        public virtual DbSet<PaRecebido> PaRecebido { get; set; }
        public virtual DbSet<PaSexo> PaSexo { get; set; }
        public virtual DbSet<PaTipoMembro> PaTipoMembro { get; set; }
        public virtual DbSet<PaUsuario> PaUsuario { get; set; }
        public virtual DbSet<PaUsuario1> PaUsuario1 { get; set; }
        public virtual DbSet<PaUsuarioPerfil> PaUsuarioPerfil { get; set; }
        public virtual DbSet<TCargo> TCargo { get; set; }
        public virtual DbSet<TCongregacao> TCongregacao { get; set; }
        public virtual DbSet<TCrianca> TCrianca { get; set; }
        public virtual DbSet<TFinanceiro> TFinanceiro { get; set; }
        public virtual DbSet<TMembro> TMembro { get; set; }
        public virtual DbSet<TObreiro> TObreiro { get; set; }
        public virtual DbSet<TUsuario> TUsuario { get; set; }
        public virtual DbSet<TVisitante> TVisitante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=mysql41-farm1.kinghost.net;database=calvariomariap;uid=calvariomariap;password=ibcmpsg2021", x => x.ServerVersion("5.5.62-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaAluno>(entity =>
            {
                entity.HasKey(e => e.CodAluno)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Aluno");

                entity.Property(e => e.CodAluno)
                    .HasColumnName("codAluno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codcampus)
                    .HasColumnName("codcampus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codcurso)
                    .HasColumnName("codcurso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Coddisciplina)
                    .HasColumnName("coddisciplina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codsemestre)
                    .HasColumnName("codsemestre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codturma)
                    .HasColumnName("codturma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PaAulas>(entity =>
            {
                entity.HasKey(e => e.CodAulas)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Aulas");

                entity.Property(e => e.CodAulas)
                    .HasColumnName("codAulas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Abono)
                    .HasColumnName("abono")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodProfessor)
                    .HasColumnName("codProfessor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Falta)
                    .HasColumnName("falta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Presenca)
                    .HasColumnName("presenca")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PaCadastro>(entity =>
            {
                entity.HasKey(e => e.CodCadastro)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Cadastro");

                entity.Property(e => e.CodCadastro)
                    .HasColumnName("codCadastro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aclamacao)
                    .HasColumnName("aclamacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Batismo)
                    .HasColumnName("batismo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BatismoData)
                    .HasColumnName("batismoData")
                    .HasColumnType("date");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CasamentoData)
                    .HasColumnName("casamentoData")
                    .HasColumnType("date");

                entity.Property(e => e.Celular)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CidadeBat)
                    .HasColumnName("cidadeBat")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodEstadoCivil)
                    .HasColumnName("codEstadoCivil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("codSexo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodTipoMembro)
                    .HasColumnName("codTipoMembro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Congregacao)
                    .HasColumnName("congregacao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataAceitoIgreja).HasColumnType("date");

                entity.Property(e => e.DataNascConjuge)
                    .HasColumnName("dataNascConjuge")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoBat)
                    .HasColumnName("estadoBat")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Formaentrada)
                    .HasColumnName("formaentrada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idade)
                    .HasColumnName("idade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Liderfamilia)
                    .HasColumnName("liderfamilia")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nacionalidade)
                    .HasColumnName("nacionalidade")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NascimentoData)
                    .HasColumnName("nascimentoData")
                    .HasColumnType("date");

                entity.Property(e => e.Naturalidade)
                    .HasColumnName("naturalidade")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomeIgrejaBat)
                    .HasColumnName("nomeIgrejaBat")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomeIgrejaTransf)
                    .HasColumnName("nomeIgrejaTransf")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nomeconjuge)
                    .HasColumnName("nomeconjuge")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nomemae)
                    .HasColumnName("nomemae")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nomepai)
                    .HasColumnName("nomepai")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Outros)
                    .HasColumnName("outros")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profissao)
                    .HasColumnName("profissao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Profissaofe)
                    .HasColumnName("profissaofe")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qtdfilhos)
                    .HasColumnName("qtdfilhos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Regional)
                    .HasColumnName("regional")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelComercial)
                    .HasColumnName("telComercial")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelResidencial)
                    .HasColumnName("telResidencial")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Transferencia)
                    .HasColumnName("transferencia")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PaEstadoCivil>(entity =>
            {
                entity.HasKey(e => e.CodEstadoCivil)
                    .HasName("PRIMARY");

                entity.ToTable("PA_EstadoCivil");

                entity.Property(e => e.CodEstadoCivil)
                    .HasColumnName("codEstadoCivil")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PaLock>(entity =>
            {
                entity.HasKey(e => new { e.CodObjeto, e.RefObjeto })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("PA_Lock");

                entity.Property(e => e.CodObjeto)
                    .HasColumnName("codObjeto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RefObjeto)
                    .HasColumnName("refObjeto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataHora).HasColumnName("dataHora");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaMenu>(entity =>
            {
                entity.HasKey(e => e.CodMenu)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Menu");

                entity.Property(e => e.CodMenu)
                    .HasColumnName("codMenu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.CodMenu, e.CodOpcao })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("PA_MenuItem");

                entity.Property(e => e.CodMenu)
                    .HasColumnName("codMenu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodOpcao)
                    .HasColumnName("codOpcao")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PaOpcao>(entity =>
            {
                entity.HasKey(e => e.CodOpcao)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Opcao");

                entity.Property(e => e.CodOpcao)
                    .HasColumnName("codOpcao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPai)
                    .HasColumnName("codPai")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaPerfil>(entity =>
            {
                entity.HasKey(e => e.CodPerfil)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Perfil");

                entity.Property(e => e.CodPerfil)
                    .HasColumnName("codPerfil")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMenu0)
                    .HasColumnName("codMenu0")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMenu1)
                    .HasColumnName("codMenu1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMenu2)
                    .HasColumnName("codMenu2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMenu3)
                    .HasColumnName("codMenu3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaPessoa>(entity =>
            {
                entity.HasKey(e => e.CodPessoa)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Pessoa");

                entity.Property(e => e.CodPessoa)
                    .HasColumnName("codPessoa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CnpjCpf)
                    .HasColumnName("cnpjCpf")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodEndereco)
                    .HasColumnName("codEndereco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodLotacao)
                    .HasColumnName("codLotacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodOrganizador)
                    .HasColumnName("codOrganizador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPessoaCategoria)
                    .HasColumnName("codPessoaCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPessoaSituacao)
                    .HasColumnName("codPessoaSituacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodTelefone)
                    .HasColumnName("codTelefone")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailDpge)
                    .HasColumnName("emailDpge")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FisJur)
                    .IsRequired()
                    .HasColumnName("fisJur")
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdFuncional)
                    .HasColumnName("idFuncional")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatriculaDv)
                    .HasColumnName("matriculaDv")
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaProfessor>(entity =>
            {
                entity.HasKey(e => e.CodProfessor)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Professor");

                entity.Property(e => e.CodProfessor)
                    .HasColumnName("codProfessor")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PaRecebido>(entity =>
            {
                entity.HasKey(e => e.CodRecebido)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Recebido");

                entity.Property(e => e.CodRecebido).HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Obs)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PaSexo>(entity =>
            {
                entity.HasKey(e => e.CodSexo)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Sexo");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("codSexo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaTipoMembro>(entity =>
            {
                entity.HasKey(e => e.CodTipoMembro)
                    .HasName("PRIMARY");

                entity.ToTable("PA_TipoMembro");

                entity.Property(e => e.CodTipoMembro)
                    .HasColumnName("codTipoMembro")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaUsuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("PA_Usuario");

                entity.HasIndex(e => e.CodPessoa)
                    .HasName("pa_usuarioPessoaIdx");

                entity.HasIndex(e => e.Login)
                    .HasName("pa_usuarioLoginIdx")
                    .IsUnique();

                entity.HasIndex(e => e.Nome)
                    .HasName("pa_usuarioNomeIdx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.CodPessoa)
                    .HasColumnName("codPessoa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PaUsuario1>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("pa_usuario");

                entity.HasIndex(e => e.CodPessoa)
                    .HasName("pa_usuarioPessoaIdx");

                entity.HasIndex(e => e.Login)
                    .HasName("pa_usuarioLoginIdx")
                    .IsUnique();

                entity.HasIndex(e => e.Nome)
                    .HasName("pa_usuarioNomeIdx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.CodPessoa)
                    .HasColumnName("codPessoa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PaUsuarioPerfil>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodPerfil })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("PA_UsuarioPerfil");

                entity.HasIndex(e => e.CodPerfil)
                    .HasName("pa_usuarioPerfilIdx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPerfil)
                    .HasColumnName("codPerfil")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TCargo>(entity =>
            {
                entity.HasKey(e => e.Codcargo)
                    .HasName("PRIMARY");

                entity.ToTable("T_CARGO");

                entity.Property(e => e.Codcargo)
                    .HasColumnName("codcargo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CgDescricao)
                    .HasColumnName("cgDescricao")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TCongregacao>(entity =>
            {
                entity.HasKey(e => e.CodCongregacao)
                    .HasName("PRIMARY");

                entity.ToTable("T_CONGREGACAO");

                entity.Property(e => e.CodCongregacao)
                    .HasColumnName("codCongregacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DtFundacao)
                    .HasColumnName("dtFundacao")
                    .HasColumnType("date");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomeResp)
                    .IsRequired()
                    .HasColumnName("nomeResp")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TCrianca>(entity =>
            {
                entity.HasKey(e => e.CodCrianca)
                    .HasName("PRIMARY");

                entity.ToTable("T_CRIANCA");

                entity.Property(e => e.CodCrianca)
                    .HasColumnName("codCrianca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CelResp)
                    .HasColumnName("celResp")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dtNascimento")
                    .HasColumnType("date");

                entity.Property(e => e.NomeCria)
                    .IsRequired()
                    .HasColumnName("nomeCria")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomeResp)
                    .IsRequired()
                    .HasColumnName("nomeResp")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelResp)
                    .HasColumnName("telResp")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TFinanceiro>(entity =>
            {
                entity.HasKey(e => e.CdLancamento)
                    .HasName("PRIMARY");

                entity.ToTable("T_FINANCEIRO");

                entity.Property(e => e.CdLancamento)
                    .HasColumnName("cdLancamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CtLancamento)
                    .IsRequired()
                    .HasColumnName("ctLancamento")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dtLancamento")
                    .HasColumnType("date");

                entity.Property(e => e.Observacao)
                    .IsRequired()
                    .HasColumnName("observacao")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TpLancamento)
                    .IsRequired()
                    .HasColumnName("tpLancamento")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VlLancamento).HasColumnName("vlLancamento");
            });

            modelBuilder.Entity<TMembro>(entity =>
            {
                entity.HasKey(e => e.CodMembro)
                    .HasName("PRIMARY");

                entity.ToTable("T_MEMBRO");

                entity.Property(e => e.CodMembro)
                    .HasColumnName("codMembro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtividadeProfissional)
                    .IsRequired()
                    .HasColumnName("atividadeProfissional")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BatismoComEs)
                    .HasColumnName("batismoComES")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CargoOcupava)
                    .HasColumnName("cargoOcupava")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnName("celular")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Congregacao)
                    .HasColumnName("congregacao")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DtBatismoAguas)
                    .HasColumnName("dtBatismoAguas")
                    .HasColumnType("date");

                entity.Property(e => e.DtCasamento)
                    .HasColumnName("dtCasamento")
                    .HasColumnType("date");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dtNascimento")
                    .HasColumnType("date");

                entity.Property(e => e.DtRecebido)
                    .HasColumnName("dtRecebido")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estadoCivil")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Funcao)
                    .HasColumnName("funcao")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GrauInstrucao)
                    .IsRequired()
                    .HasColumnName("grauInstrucao")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IgrejaBatismo)
                    .HasColumnName("igrejaBatismo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IgrejaProcedencia)
                    .HasColumnName("igrejaProcedencia")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LiderFamiliar)
                    .HasColumnName("liderFamiliar")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nacionalidade)
                    .IsRequired()
                    .HasColumnName("nacionalidade")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Naturalidade)
                    .IsRequired()
                    .HasColumnName("naturalidade")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NomeConjuge)
                    .HasColumnName("nomeConjuge")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NomeMae)
                    .HasColumnName("nomeMae")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NomePai)
                    .HasColumnName("nomePai")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NumFilhos)
                    .HasColumnName("numFilhos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Origem)
                    .HasColumnName("origem")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Profissao)
                    .IsRequired()
                    .HasColumnName("profissao")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RecebidoPorAclamacao)
                    .HasColumnName("recebidoPorAclamacao")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RecebidoPorCarta)
                    .HasColumnName("recebidoPorCarta")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Telefone1)
                    .HasColumnName("telefone1")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Telefone2)
                    .HasColumnName("telefone2")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TempoQueOcupou)
                    .HasColumnName("tempoQueOcupou")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("uf")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TObreiro>(entity =>
            {
                entity.HasKey(e => e.CodObreiro)
                    .HasName("PRIMARY");

                entity.ToTable("T_OBREIRO");

                entity.Property(e => e.CodObreiro)
                    .HasColumnName("codObreiro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCargo)
                    .HasColumnName("codCargo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMembro)
                    .HasColumnName("codMembro")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.CdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("T_USUARIO");

                entity.Property(e => e.CdUsuario)
                    .HasColumnName("cdUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasColumnName("perfil")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TVisitante>(entity =>
            {
                entity.HasKey(e => e.CodVisit)
                    .HasName("PRIMARY");

                entity.ToTable("T_VISITANTE");

                entity.Property(e => e.CodVisit)
                    .HasColumnName("codVisit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dtNascimento")
                    .HasColumnType("date");

                entity.Property(e => e.DtVisita)
                    .HasColumnName("dtVisita")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
