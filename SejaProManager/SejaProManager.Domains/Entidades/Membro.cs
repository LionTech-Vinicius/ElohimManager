using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SejaProManager.Domains.Entidades
{
    [Table("T_MEMBRO")]
    public class Membro : Pessoa
    {
        [StringLength(50)]
        public string Profissao { get; set; }
        [StringLength(50)]
        public string AtividadeProfissional { get; set; }
        public DateTime DtBatismo { get; set; }
        [StringLength(150)]
        public string NomeIgrejaBat { get; set; }
        public Boolean BatismoComES { get; set; }
        public Boolean RecebidoPorCarta { get; set; }
        public Boolean RecebidoPorAclamacao { get; set; }
        public DateTime DtRecebido { get; set; }
        [StringLength(250)]
        public string Motivo { get; set; }
        [StringLength(150)]
        public string IgrejaProcedencia { get; set; }
        [StringLength(50)]
        public string CargoOcupado { get; set; }
        [StringLength(50)]
        public string TempoOcupado { get; set; }
        [StringLength(250)]
        public string LiderFamiliar { get; set; }
        [StringLength(20)]
        public string EstadoCivil { get; set; }
        public DateTime DtCasamento { get; set; }
        [StringLength(250)]
        public string NomeConjuge { get; set; }
        public int QtdFilhos { get; set; }
        [StringLength(500)]
        public string Observacao { get; set; }

        public int CongregacaoId { get; set; }

        [ForeignKey("CongregacaoId")]
        public Congregacao Congregacao { get; set; }
    }
}

