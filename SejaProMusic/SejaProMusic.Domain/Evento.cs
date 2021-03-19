using System;
using System.Collections.Generic;
using System.Text;

namespace SejaProMusic.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraEvento { get; set; }
        public List<Pessoa> Participantes { get; set; }
        public List<Musica> Musicas { get; set; }


        public DateTime Criado { get; set; }
        public DateTime Ataualizado { get; set; }
    }
}
