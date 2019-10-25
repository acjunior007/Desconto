using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Maps
{
    [Table("DESDESCONTO")]
    public class DescontoDbMap
    {
        [Key]
        [Column("DESCOD")]
        public int Codigo { get; set; }

        [Column("PESCOD")]
        public int? CodigoPessoa { get; set; }

        [Column("PERCOD")]
        public int Percod { get; set; }

        [Column("DISCOD_INDICADO")]
        public int? DiscodIndicado { get; set; }

        [Column("SENCOD")]
        public int? Sencod { get; set; }

        [Column("USUCOD_CADASTRO")]
        public int? UsucodCadastro { get; set; }

        [Column("DESDATA_DESCONTO", TypeName = "datetime")]
        public DateTime? DesdataDesconto { get; set; }

        [Column("COD_MEDICAMENTO")]
        public int? CodMedicamento { get; set; }

        [Column("DESQUANTIDADE", TypeName = "decimal(8, 2)")]
        public decimal? Desquantidade { get; set; }

        [Column("DESSTATUS")]
        public int? Desstatus { get; set; }

        [Column("USUCOD_BAIXA")]
        public int? UsucodBaixa { get; set; }

        [Column("DISCOD_BAIXA")]
        public int? DiscodBaixa { get; set; }

        [Column("DESDATA_BAIXA", TypeName = "datetime")]
        public DateTime? DesdataBaixa { get; set; }

        [Column("MODCOD")]
        public int? Modcod { get; set; }
        [Column("DESDATA_ANALISE", TypeName = "datetime")]
        public DateTime? DesdataAnalise { get; set; }
        [Column("USUCOD_ANALISE")]
        public int? UsucodAnalise { get; set; }
        [Column("MOGCOD")]
        public int? Mogcod { get; set; }
        [Column("DESDATA_BAIXA_GLOSA", TypeName = "datetime")]
        public DateTime? DesdataBaixaGlosa { get; set; }
        [Column("USUCOD_BAIXA_GLOSA")]
        public int? UsucodBaixaGlosa { get; set; }
        [Column("PRCCOD")]
        public int? Prccod { get; set; }

        [Column("DESPRECISOU_AUTORIZAR")]
        public int? DesprecisouAutorizar { get; set; }
        [Column("DESUSUARIO_AUTORIZACAO")]
        public int? DesusuarioAutorizacao { get; set; }
        [Column("PECCOD")]
        public int? Peccod { get; set; }
        [Column("DESARQUIVO")]
        public byte[] Desarquivo { get; set; }
        [Column("DESNOME_ARQUIVO")]
        [StringLength(500)]
        public string DesnomeArquivo { get; set; }
        [Column("UNSCOD")]
        public int? Unscod { get; set; }
        [Column("UNSCOD_BAIXA")]
        public int? UnscodBaixa { get; set; }
        [Column("DESDATA_VENDA", TypeName = "datetime")]
        public DateTime? DesdataVenda { get; set; }
    }
}