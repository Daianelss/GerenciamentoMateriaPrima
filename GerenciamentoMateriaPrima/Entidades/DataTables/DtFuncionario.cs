using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Entidades.DataTables
{
    public static class DtFuncionario
    {
        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Nome", typeof(string));
            Dt.Columns.Add("StatusValor", typeof(int));
            Dt.Columns.Add("Status", typeof(string));
        }


        public static DataTable PreencherFuncionarios(IEnumerable<BaseModel> funcionarios)
        {
            SetColunas();

            if (funcionarios == null)
                return Dt;

            foreach (var funcionario in funcionarios as IEnumerable<Funcionario>)
            {
                Dt.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Status, funcionario.Status == 1 ? "Ativo" : "Inativo");
            }

            return Dt;
        }
    }
}
