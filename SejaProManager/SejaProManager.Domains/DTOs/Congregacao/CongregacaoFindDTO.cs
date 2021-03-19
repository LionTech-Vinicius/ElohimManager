using System;

namespace SejaProManager.Domains.DTOs.Congregacao
{
    public class CongregacaoFindDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeResp { get; set; }
        public DateTime DtFundacao { get; set; }
        public string Observacao { get; set; }
    }
}
