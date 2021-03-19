using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaAluno
    {
        public int CodAluno { get; set; }
        public string Nome { get; set; }
        public int? Codcurso { get; set; }
        public int? Codsemestre { get; set; }
        public int? Codturma { get; set; }
        public int? Coddisciplina { get; set; }
        public int? Codcampus { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
