using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaPerfil
    {
        public int CodPerfil { get; set; }
        public int? Ativo { get; set; }
        public string Descricao { get; set; }
        public int? CodMenu0 { get; set; }
        public int? CodMenu1 { get; set; }
        public int? CodMenu2 { get; set; }
        public int? CodMenu3 { get; set; }
    }
}
