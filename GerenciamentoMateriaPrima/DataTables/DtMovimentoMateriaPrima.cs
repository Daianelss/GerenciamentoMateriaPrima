using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.DataTables
{
    public class DtMovimentoMateriaPrima
    {
        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Peso", typeof(double));
            Dt.Columns.Add("Descricao", typeof(string));
            Dt.Columns.Add("Data", typeof(DateTime));
            Dt.Columns.Add("EntradaSaidaValor", typeof(int));
            Dt.Columns.Add("EntradaSaida", typeof(string));
            Dt.Columns.Add("TipoMateriaPrimaId", typeof(int));
            Dt.Columns.Add("TipoMateriaPrima", typeof(string));

        }

        public static DataTable PreencherMovimentoMateriaPrima(IEnumerable<MovimentoMateriaPrima> movimentoMateriaPrimas)
        {
            SetColunas();
            foreach (var movimentoMateriaPrima in movimentoMateriaPrimas)
            {
                Dt.Rows.Add
                    (
                        movimentoMateriaPrima.Id,
                        movimentoMateriaPrima.Peso,
                        movimentoMateriaPrima.Descricao,
                        movimentoMateriaPrima.Data,
                        movimentoMateriaPrima.EntradaSaida,
                        movimentoMateriaPrima.EntradaSaida == 1 ? "Entrada" : "Saída",
                        movimentoMateriaPrima.TipoMateriaPrimaId,
                        movimentoMateriaPrima.TipoMateriaPrima.Nome
                    );
            }
            return Dt;
        }

    }
}
