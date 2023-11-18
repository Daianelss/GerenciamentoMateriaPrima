using GerenciamentoMateriaPrima.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoMateriaPrima.Model
{
    [Table("movimento_materia_prima")]
    public class MovimentoMateriaPrima : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MATE_ID")]
        [Description("")]
        public new int Id { get; set; }

        [Column("MATE_PESO")]
        [Description("")]
        public double Peso { get; set; }

        [Column("MATE_DESCRICAO")]
        [Description("")]
        public string Descricao { get; set; }

        [Column("MATE_DATA")]
        [Description("")]
        public DateTime Data { get; set; }


        [Column("MATE_ENTRADA_SAIDA")]
        [Description("")]
        public int EntradaSaida { get; set; }


        [Column("MATE_TPMP_ID")]
        [Description("")]
        public int TipoMateriaPrimaId { get; set; }

        [ForeignKey("TipoMateriaPrimaId")]
        public virtual TipoMateriaPrima TipoMateriaPrima { get; set; }



    }
}
