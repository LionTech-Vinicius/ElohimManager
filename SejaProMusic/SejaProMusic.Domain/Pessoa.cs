using System;
using System.Collections.Generic;

namespace SejaProMusic.Domain
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public Endereco Endereco { get; set; }

        public List<Contato> Contatos { get; set; }

        public DateTime Criado { get; set; }
        public DateTime Atualizado { get; set; }
    }
}