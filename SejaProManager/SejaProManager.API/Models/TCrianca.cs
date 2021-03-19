using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TCrianca
    {
        public int CodCrianca { get; set; }
        public string NomeCria { get; set; }
        public string NomeResp { get; set; }
        public string TelResp { get; set; }
        public string CelResp { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Observacao { get; set; }
    }
}
