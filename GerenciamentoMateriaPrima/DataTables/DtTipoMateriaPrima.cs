using GerenciamentoMateriaPrima.Interfaces;
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
            Dt.Columns.Add("StatusValor", typeof(int));
            Dt.Columns.Add("Status", typeof(string));

        }

        public static DataTable PreencherTipoMateriaPrima<T>(IEnumerable<T> materiaPrimas) where T : BaseModel
        {
            SetColunas();
            foreach (var materiaPrima in materiaPrimas as IEnumerable<TipoMateriaPrima>)
            {
                Dt.Rows.Add(materiaPrima.Id, materiaPrima.Nome, materiaPrima.Descricao, materiaPrima.Status, materiaPrima.Status == 1 ? "Ativo" : "Inativo");
            }

            return Dt;
        }


    }
}
