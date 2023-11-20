using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Entidades.DataTables
{
    public class DtMovimento
    {
        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Data", typeof(DateTime));
            Dt.Columns.Add("PesoEntrada", typeof(string));
            Dt.Columns.Add("PesoSaida", typeof(string));
            Dt.Columns.Add("Descricao", typeof(string));
            Dt.Columns.Add("TipoProcessoId", typeof(int));
            Dt.Columns.Add("TipoProcesso", typeof(string));
            Dt.Columns.Add("FuncionarioId", typeof(int));
            Dt.Columns.Add("Funcionario", typeof(string));
            Dt.Columns.Add("Quebra", typeof(string));
        }

        public static DataTable PreencherMovimento(IEnumerable<BaseModel> movimentos)
        {
            SetColunas();

            if (movimentos == null)
                return Dt;

            foreach (var movimento in movimentos as IEnumerable<Movimento>)
            {
                Dt.Rows.Add(
                    movimento.Id,
                    movimento.Data,
                    movimento.PesoEntrada.ToString("F2"),
                    movimento.PesoSaida.ToString("F2"),
                    movimento.Descricao,
                    movimento.TipoProcessoId,
                    movimento.TipoProcesso.Nome,
                    movimento.FuncionarioId,
                    movimento.Funcionario.Nome,
                    movimento.Quebra.ToString("F2")
                    );
            }
            return Dt;
        }


    }
}
