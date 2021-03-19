using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaAulas
    {
        public int CodAulas { get; set; }
        public int Matricula { get; set; }
        public DateTime? Data { get; set; }
        public int? Presenca { get; set; }
        public int? Abono { get; set; }
        public int? Falta { get; set; }
        public int? CodProfessor { get; set; }
    }
}
