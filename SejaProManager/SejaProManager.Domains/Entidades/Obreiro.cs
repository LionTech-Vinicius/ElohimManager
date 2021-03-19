using System.ComponentModel.DataAnnotations.Schema;

namespace SejaProManager.Domains.Entidades
{
    public class Obreiro
    {
        public int Id { get; set; }
        public int MembroId { get; set; }
        public int CargoId { get; set; }

        [ForeignKey("MembroId")]
        public Membro Membro { get; set; }

        [ForeignKey("CargoId")]
        public Cargo Cargo { get; set; }
    }
}
