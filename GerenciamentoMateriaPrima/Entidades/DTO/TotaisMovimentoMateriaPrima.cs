using GerenciamentoMateriaPrima.Entidades.Enum;

namespace GerenciamentoMateriaPrima.Entidades.DTO
{
    public class TotaisMovimentoMateriaPrima
    {
        public int EntradaSaida { get; set; }
        public double Total { get; set; }

        public TipoMovimentoMateriaPrima TipoMovimentoMateriaPrima { get => EntradaSaida == 1 ? TipoMovimentoMateriaPrima.Entrada : TipoMovimentoMateriaPrima.Saida; }
    }




}
