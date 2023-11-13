using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.DataTables
{
    public class DtTipoProcesso
    {
        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Nome", typeof(string));
            Dt.Columns.Add("Descricao", typeof(string));
            Dt.Columns.Add("StatusValor", typeof(int));
            Dt.Columns.Add("Status", typeof(string));
        }

        public static DataTable PreencherTipoProcesso(IEnumerable<TipoProcesso> tipoProcessos)
        {
            SetColunas();
            foreach (var tipoProcesso in tipoProcessos)
            {
                Dt.Rows.Add(tipoProcesso.Id, tipoProcesso.Nome, tipoProcesso.Descricao, tipoProcesso.Status, tipoProcesso.Status == 1 ? "Ativo" : "Inativo");
            }

            return Dt;
        }
    }
}
