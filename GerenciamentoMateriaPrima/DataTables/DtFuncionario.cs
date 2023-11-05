using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.DataTables
{
    public static class DtFuncionario
    {

        public static DataTable Dt {  get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Nome", typeof(string));
            Dt.Columns.Add("Status", typeof(int));

            Dt.Columns["Id"].ColumnMapping = MappingType.Hidden;
        }


        public static DataTable PreencherFuncionarios(IEnumerable<Funcionario> funcionarios)
        {
            SetColunas();
            foreach (var funcionario in funcionarios)
            {
                Dt.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Status);
            }

            return Dt;
        }


    }
}
