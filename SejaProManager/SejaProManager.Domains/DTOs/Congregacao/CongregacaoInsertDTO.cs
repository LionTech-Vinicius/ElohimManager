using SejaProManager.Domains.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProManager.Domains.DTOs.Congregacao
{
    public class CongregacaoInsertDTO
    {
        public string Nome { get; set; }
        public string NomeResp { get; set; }
        public DateTime DtFundacao { get; set; }
        public string Observacao { get; set; }

        public List<Contato> Contatos { get; set; }
        public Endereco Endereco { get; set; }
    }
}
