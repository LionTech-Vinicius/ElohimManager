using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProManager.Domains.DTOs.Financeiro
{
    public class FinanceiroUpdateDTO
    {
        public int Id { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Descricao { get; set; }
        public double VlLancamento { get; set; }
        public string ContaLancamento { get; set; } //Categoria de Lançamento Financiero
        public string TipoLancamento { get; set; }
        public string ObsLancamento { get; set; }
    }
}
