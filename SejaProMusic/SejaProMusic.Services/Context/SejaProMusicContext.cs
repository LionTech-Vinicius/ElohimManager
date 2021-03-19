using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProMusic.Services.Context
{
    public class SejaProMusicContext : DbContext
    {
        public SejaProMusicContext(DbContextOptions<SejaProMusicContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EventoMap());
            modelBuilder.ApplyConfiguration(new MusicaMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            
            foreach(var entry in ChangeTracker.Entries<ITrackableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Criado").CurrentValue = DateTime.UtcNow;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Atualizado").CurrentValue = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }
}
