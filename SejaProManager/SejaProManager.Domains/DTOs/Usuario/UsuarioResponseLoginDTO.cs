using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProManager.Domains.DTOs.Usuario
{
    public class UsuarioResponseLoginDTO
    {
        public string Nome { get; set; }
        public string Perfil { get; set; }
        public bool UserExistente { get; set; }
        public string Erro { get; set; }
    }
}
