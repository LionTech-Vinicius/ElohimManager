using System;
using System.Collections.Generic;

namespace SejaProManager.API.Models
{
    public partial class PaPessoa
    {
        public int CodPessoa { get; set; }
        public int CodOrganizador { get; set; }
        public int CodPessoaCategoria { get; set; }
        public string FisJur { get; set; }
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public string Email { get; set; }
        public string EmailDpge { get; set; }
        public int? Matricula { get; set; }
        public string MatriculaDv { get; set; }
        public int? IdFuncional { get; set; }
        public int? CodLotacao { get; set; }
        public int? CodPessoaSituacao { get; set; }
        public int? CodEndereco { get; set; }
        public int? CodTelefone { get; set; }
    }
}
