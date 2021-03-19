using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SejaProManager.Domains.Entidades
{
    [Table("T_PESSOA")]
    public abstract class Pessoa
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250)]
        public string Nome { get; set; }
        [StringLength(250)]
        public string NomeMae { get; set; }
        [StringLength(250)]
        public string NomePai { get; set; }
        public DateTime DtNascimento { get; set; }
        [StringLength(50)]
        public string GrauInstrucao { get; set; }
        [StringLength(20)]
        public string Sexo { get; set; }
        [StringLength(20)]
        public string Rg { get; set; }
        [StringLength(50)]
        public string RgEmissao { get; set; }
        [StringLength(20)]
        public string Cpf { get; set; }
        [StringLength(50)]
        public string Nacionalidade { get; set; }
        [StringLength(150)]
        public string Naturalidade { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Active { get; set; }

        public List<Contato> Contatos { get; set; }
        public List<Endereco> Endereco { get; set; }

    }
}
