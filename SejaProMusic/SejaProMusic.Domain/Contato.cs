namespace SejaProMusic.Domain
{
    public class Contato
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public bool? RedeSocial { get; set; }
        public bool? Principal { get; set; }
    }
}