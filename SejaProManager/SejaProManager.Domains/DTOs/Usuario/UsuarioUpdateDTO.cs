using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProManager.Domains.DTOs.Usuario
{
    public class UsuarioUpdateDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}
