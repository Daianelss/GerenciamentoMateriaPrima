using System.ComponentModel;

namespace GerenciamentoMateriaPrima.Entidades.Enum
{
    public enum TipoMovimentoMateriaPrima
    {
        [Description("Entrada de Materia Prima")]
        Entrada,

        [Description("Saída de Materia Prima")]
        Saida
    }
}
