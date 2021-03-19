using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SejaProManager.Domains.Entidades
{
    [Table("T_ENDERECO")]
    public class Endereco
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250)]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        [StringLength(150)]
        public string Bairro { get; set; }
        [StringLength(150)]
        public string Cidade { get; set; }
        [StringLength(2)]
        public string Uf { get; set; }
        [StringLength(15)]
        public string Cep { get; set; }
        [StringLength(250)]
        public string Complemento { get; set; }

        public int? PessoaId { get; set; }
        [ForeignKey("PessoaId")]
        public Pessoa Pessoa { get; set; }

        public int? CongregacaoId { get; set; }
        [ForeignKey("CongregacaoId")]
        public Congregacao Congregacao { get; set; }
    }
}
