using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class TMembro
    {
        public int CodMembro { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Congregacao { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string GrauInstrucao { get; set; }
        public string Sexo { get; set; }
        public string Profissao { get; set; }
        public string AtividadeProfissional { get; set; }
        public string Rg { get; set; }
        public string Origem { get; set; }
        public string Cpf { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime? DtCasamento { get; set; }
        public string NomeConjuge { get; set; }
        public int? NumFilhos { get; set; }
        public DateTime? DtBatismoAguas { get; set; }
        public string IgrejaBatismo { get; set; }
        public string BatismoComEs { get; set; }
        public string RecebidoPorCarta { get; set; }
        public string RecebidoPorAclamacao { get; set; }
        public DateTime? DtRecebido { get; set; }
        public string Motivo { get; set; }
        public string IgrejaProcedencia { get; set; }
        public string CargoOcupava { get; set; }
        public string TempoQueOcupou { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Observacao { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string LiderFamiliar { get; set; }
    }
}
