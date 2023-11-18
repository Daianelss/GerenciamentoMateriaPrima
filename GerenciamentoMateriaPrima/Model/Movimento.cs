using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoMateriaPrima.Model
{
    [Table("movimento")]
    public class Movimento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MOVI_ID")]
        [Description("")]
        public int Id { get; set; }

        [Column("MOVI_DATE")]
        [Description("")]
        public DateTime Data { get; set; }

        [Column("MOVI_PESO_ENTRADA")]
        [Description("")]
        public double PesoEntrada { get; set; }

        [Column("MOVI_PESO_SAIDA")]
        [Description("")]
        public double PesoSaida { get; set; }

        [Column("MOVI_DESC")]
        [Description("")]
        public string Descricao { get; set; }

        [Column("MOVI_TIPR_ID")]
        [Description("")]
        public int TipoProcessoId { get; set; }

        [ForeignKey("TipoProcessoId")]
        public virtual TipoProcesso TipoProcesso { get; set; }

        [Column("MOVI_FUNC_ID")]
        [Description("")]
        public int FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario Funcionario { get; set; }

        [NotMapped]
        public double Quebra { get => PesoEntrada - PesoSaida; }




    }
}
