using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaLock
    {
        public int CodObjeto { get; set; }
        public int RefObjeto { get; set; }
        public DateTime DataHora { get; set; }
        public int CodUsuario { get; set; }
        public string Descricao { get; set; }
    }
}
