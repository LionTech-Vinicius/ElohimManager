using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SejaProManager.Domains.Entidades
{
    [Table("Financeiro")]
    public class Financeiro
    {
        public int Id { get; set; } 
        public DateTime DtLancamento { get; set; }
        [StringLength(250)]
        public string Descricao { get; set; }
        public double VlLancamento { get; set; }
        [StringLength(50)]
        public string ContaLancamento { get; set; } //Categoria de Lançamento Financiero
        [StringLength(50)]
        public string TipoLancamento { get; set; }
        [StringLength(250)]
        public string ObsLancamento { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
