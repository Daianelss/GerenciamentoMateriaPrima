using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoMateriaPrima.Model
{
    [Table("tipo_processo")]
    public class TipoProcesso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TIPR_ID")]
        [Description("")]
        public int Id { get; set; }
        [Column("TIPR_NOME")]
        [Description("")]
        public string Nome { get; set; }
        [Column("TIPR_DESCRICAO")]
        [Description("")]
        public string Descricao { get; set; }
        [Column("TIPR_STATUS")]
        [Description("")]
        public int Status { get; set; }
    }
}
