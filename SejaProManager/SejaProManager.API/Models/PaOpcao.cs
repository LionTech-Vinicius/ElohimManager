using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaOpcao
    {
        public int CodOpcao { get; set; }
        public int CodPai { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Nivel { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }
    }
}
