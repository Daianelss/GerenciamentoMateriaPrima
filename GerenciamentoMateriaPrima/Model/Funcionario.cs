using GerenciamentoMateriaPrima.Model.DAL;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoMateriaPrima.Model
{
    [Table("funcionario")]
    public class Funcionario : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FUNC_ID")]
        [Description("")]
        public new int Id { get; set; }

        [Column("FUNC_NOME")]
        [Description("")]
        public string Nome { get; set; }

        [Column("FUNC_STATUS")]
        [Description("")]
        public int Status { get; set; }
    }
}
