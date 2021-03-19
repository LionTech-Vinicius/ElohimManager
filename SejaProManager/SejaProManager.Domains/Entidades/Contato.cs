using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SejaProManager.Domains.Entidades
{
    [Table("T_CONTATO")]
    public class Contato
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Tipo { get; set; }
        [StringLength(150)]
        public string Descricao { get; set; }
        public int? PessoaId { get; set; }
        public int? CongregacaoId { get; set; }

        [ForeignKey("PessoaId")]
        public Pessoa Pessoa { get; set; }
        
        [ForeignKey("CongregacaoId")]
        public Congregacao Congregacao { get; set; }
    }
}
