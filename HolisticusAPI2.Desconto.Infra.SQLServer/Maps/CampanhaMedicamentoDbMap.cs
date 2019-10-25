using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Maps
{
    [Table("CAECAMPANHA_MEDICAMENTO")]
    public partial class CampanhaMedicamentoDbMap
    {
        [Column("CAMCOD")]
        public int CodigoCampanha { get; set; }

        [Column("COD_MEDICAMENTO")]
        public int CodigoMedicamento { get; set; }

        [Column("CAETERAPIA_ATUAL")]
        public int TerapiaAtual { get; set; }

        [Column("CAETERAPIA_ANTERIOR")]
        public int TerapiaAnterior { get; set; }

        [Column("CAEVERIFICA_DIA_APLICACAO")]
        public int VerificaDiaAplicacao { get; set; }

        [Column("CAEREALIZA_INFUSAO")]
        public int? RealizaInfusao { get; set; }

        [Column("CAEGERA_VOUCHER")]
        public int? GeraVoucher { get; set; }

        [Column("CAEINTERVALO_INFUSAO")]
        public int? IntervaloInfusao { get; set; }

        [Column("CAEDOSE_ATAQUE")]
        public int? DoseAtaque { get; set; }

        [Column("CAEDIAS_DOSE_2")]
        public int? DiasDose2 { get; set; }

        [Column("CAEDIAS_DOSE_3")]
        public int? DiasDose3 { get; set; }

        [Column("CAEMAIS100KG")]
        public int? Mais100kg { get; set; }

        [Column("CAESTATUS_ACESSO")]
        public int? EstatusAcesso { get; set; }

        [Column("CAEVERIFICA_FREQUENCIA")]
        public int? VerificaFrequencia { get; set; }

        [Column("CAECONCOMITANTE")]
        public int? Econcomitante { get; set; }

        [Column("CAEVERIFICA_DOSAGEM")]
        public int VerificaDosagem { get; set; }

        [Column("CAEREALIZA_APLICACAO")]
        public int? RealizaAplicacao { get; set; }

        [Column("CAEFATURAMENTO_APLICACAO")]
        public int? FaturamentoAplicacao { get; set; }

        [Column("CAEFATURAMENTO_INFUSAO")]
        public int? FaturamentoInfusao { get; set; }

        [Key]
        [Column("CAECOD")]
        public int Codigo { get; set; }

        [Column("CAECONTROLA_ESTOQUE")]
        public bool ControlaEstoque { get; set; }

        [Column("CAEVALIDADE_SENHA")]
        public int? ValidadeSenha { get; set; }

        [Column("CAEQTDE_MAXIMA_MEDICAMENTO")]
        public int? QtdeMaximaMedicamento { get; set; }
    }
}