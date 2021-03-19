using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TCongregacao
    {
        public int CodCongregacao { get; set; }
        public string Nome { get; set; }
        public string NomeResp { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DtFundacao { get; set; }
        public string Observacao { get; set; }
    }
}
