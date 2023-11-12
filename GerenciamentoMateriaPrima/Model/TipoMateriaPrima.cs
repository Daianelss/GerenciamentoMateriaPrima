using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMateriaPrima.Model
{
    [Table("tipo_materia_prima")]
    public class TipoMateriaPrima
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TIMP_ID")]
        [Description("")]
        public new int Id { get; set; }

        [Column("TIMP_NOME")]
        [Description("")]
        public string Nome { get; set; }

        [Column("TIMP_DESCRICAO")]
        [Description("")]
        public string Descricao { get; set; }

        [Column("TIMP_STATUS")]
        [Description("")]
        public int Status { get; set; }

        public ICollection<MovimentoMateriaPrima> MovimentosMateriaPrima { get;}
    }
}
