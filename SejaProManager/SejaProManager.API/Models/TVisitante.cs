using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TVisitante
    {
        public int CodVisit { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime? DtNascimento { get; set; }
        public DateTime? DtVisita { get; set; }
    }
}
