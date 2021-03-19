using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaCadastro
    {
        public int CodCadastro { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Profissao { get; set; }
        public string Nacionalidade { get; set; }
        public int? CodEstadoCivil { get; set; }
        public int? CodSexo { get; set; }
        public int? CodTipoMembro { get; set; }
        public DateTime? NascimentoData { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int? Cep { get; set; }
        public string Estado { get; set; }
        public string TelComercial { get; set; }
        public string TelResidencial { get; set; }
        public string Celular { get; set; }
        public string Naturalidade { get; set; }
        public int? Idade { get; set; }
        public string Nomemae { get; set; }
        public string Nomepai { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Liderfamilia { get; set; }
        public string Nomeconjuge { get; set; }
        public DateTime? DataNascConjuge { get; set; }
        public DateTime? BatismoData { get; set; }
        public DateTime? CasamentoData { get; set; }
        public string Congregacao { get; set; }
        public string Regional { get; set; }
        public int? Formaentrada { get; set; }
        public int? Qtdfilhos { get; set; }
        public string NomeIgrejaTransf { get; set; }
        public string NomeIgrejaBat { get; set; }
        public string CidadeBat { get; set; }
        public string EstadoBat { get; set; }
        public DateTime? DataAceitoIgreja { get; set; }
        public string Cargo { get; set; }
        public int? Transferencia { get; set; }
        public int? Aclamacao { get; set; }
        public int? Profissaofe { get; set; }
        public int? Batismo { get; set; }
        public int? Outros { get; set; }
        public string Observacao { get; set; }
    }
}
