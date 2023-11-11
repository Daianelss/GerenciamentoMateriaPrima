using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.DataTables
{
    public class DtTipoMateriaPrima
    {

        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Nome", typeof(string));
            Dt.Columns.Add("Descricao", typeof(string));
            Dt.Columns.Add("Status", typeof(int));

        }

        public static DataTable PreencherTipoMateriaPrima(IEnumerable<TipoMateriaPrima> materiaPrimas)
        {
            SetColunas();
            foreach (var materiaPrima in materiaPrimas)
            {
                Dt.Rows.Add(materiaPrima.Id, materiaPrima.Nome, materiaPrima.Descricao, materiaPrima.Status);
            }

            return Dt;
        }


    }
}
