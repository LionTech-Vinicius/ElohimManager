using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TUsuario
    {
        public int CdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}
