using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SejaProMusic.Domain;

namespace SejaProMusic.Services.Context
{
    public class MusicaMap : IEntityTypeConfiguration<Musica>
    {
        public void Configure(EntityTypeBuilder<Musica> builder)
        {
            builder.ToTable("Musicas");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).useIdentityColumn();
        }
    }
}