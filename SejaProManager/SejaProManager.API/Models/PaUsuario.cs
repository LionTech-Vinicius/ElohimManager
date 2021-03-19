using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaUsuario
    {
        public int CodUsuario { get; set; }
        public bool? Ativo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int? CodPessoa { get; set; }
    }
}
