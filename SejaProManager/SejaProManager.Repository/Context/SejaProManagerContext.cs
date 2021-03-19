using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.Entidades;

namespace SejaProManager.Repository.Context
{
    public class SejaProManagerContext : DbContext
    {
        public SejaProManagerContext(DbContextOptions<SejaProManagerContext> options) : base(options)
        {

        }

        public DbSet<Membro> Membros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Congregacao> Congregacoes { get; set; }
        public DbSet<Financeiro> Financeiros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
