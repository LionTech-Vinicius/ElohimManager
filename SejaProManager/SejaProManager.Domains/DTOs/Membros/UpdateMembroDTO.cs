using SejaProManager.Domains.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProManager.Domains.DTOs.Membros
{
    public class UpdateMembroDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
