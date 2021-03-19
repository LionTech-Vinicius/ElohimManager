using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SejaProManager.Domains.Entidades
{
    [Table("T_CONGREGACAO")]
    public class Congregacao
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string  Nome { get; set; }
        [StringLength(150)]
        public string NomeResp { get; set; }
        public DateTime DtFundacao { get; set; }
        [StringLength(500)]
        public string Observacao { get; set; }

        public List<Membro> Membros { get; set; }
        public List<Contato> Contatos { get; set; }
        public Endereco Endereco { get; set; }
    }
}
