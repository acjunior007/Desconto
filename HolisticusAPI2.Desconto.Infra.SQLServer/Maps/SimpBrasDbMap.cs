using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Maps
{
    [Table("SIMP_BRAS")]
    public class SimpBrasDbMap
    {
        [Key]
        [Column("COD")]
        public int Codigo { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("PRECISA_APROVACAO")]
        public string PrecisaAProvacao { get; set; }

        [Column("VISUALIZA_SITE")]
        public string VisualizaSite { get; set; }
    }
}
