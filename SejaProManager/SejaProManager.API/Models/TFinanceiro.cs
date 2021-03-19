using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TFinanceiro
    {
        public int CdLancamento { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Descricao { get; set; }
        public float VlLancamento { get; set; }
        public string CtLancamento { get; set; }
        public string TpLancamento { get; set; }
        public string Observacao { get; set; }
    }
}
