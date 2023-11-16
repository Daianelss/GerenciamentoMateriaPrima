using ClosedXML.Excel;
using System.Data;

namespace GerenciamentoMateriaPrima.Services
{
    public class PlanilhaService
    {
        private string _caminhoCompleto;
        private string _nomePlanilha;


        public PlanilhaService(string caminhoCompleto, string nomePlanilha)
        {
            _caminhoCompleto = caminhoCompleto;
            _nomePlanilha = nomePlanilha;
        }

        public void GerarPlanilhaDoDataTable(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
                throw new Exception("Não há registros para gerar Excel!");

            try
            {
                using var workBook = new XLWorkbook();
                var workSheet = workBook.Worksheets.Add(_nomePlanilha);

                //Preenchendo o cabeçalho
                for (int c = 0; c < dataTable.Columns.Count; c++)
                    workSheet.Cell(row: 1, column: c + 1).Value = dataTable.Columns[c].ColumnName;

                //Preenchendo valores
                for (int r = 0; r < dataTable.Rows.Count; r++)
                    for (int c = 0; c < dataTable.Columns.Count; c++)
                        workSheet.Cell(row: r + 2, column: c + 1).Value = dataTable.Rows[r][c].ToString();

                workBook.SaveAs(_caminhoCompleto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao gerar o Excel: {ex.Message}");
            }
        }

        public void GerarPlanilhaDoDataGridView(DataGridView dataGridView)
        {
            var colunasDeletar = new List<int>();

            if (dataGridView.Rows.Count == 0)
                throw new Exception("Não há registros para gerar Excel!");

            try
            {
                using var workBook = new XLWorkbook();
                var workSheet = workBook.Worksheets.Add(_nomePlanilha);

                //Preenchendo o cabeçalho
                for (int c = 0; c < dataGridView.Columns.Count; c++)
                    if (dataGridView.Columns[c].Visible)
                        workSheet.Cell(row: 1, column: c + 1).Value = dataGridView.Columns[c].Name;
                    else
                        colunasDeletar.Add(c + 1);

                //Preenchendo valores
                for (int r = 0; r < dataGridView.Rows.Count; r++)
                    for (int c = 0; c < dataGridView.Columns.Count; c++)
                        if (dataGridView.Rows[r].Cells[c].Visible)
                            workSheet.Cell(row: r + 2, column: c + 1).Value = dataGridView.Rows[r].Cells[c].Value.ToString();

                //Removendo colunas com cabeçalhos vazios
                for (int i = 0; i < colunasDeletar.Count; i++)
                {
                    workSheet.Column(colunasDeletar[i]).Delete();

                    for (int j = 0; j < colunasDeletar.Count; j++)
                        colunasDeletar[j] -= 1;
                }
                workBook.SaveAs(_caminhoCompleto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao gerar o Excel: {ex.Message}");
            }
        }
    }
}
