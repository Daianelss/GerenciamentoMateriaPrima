using GerenciamentoMateriaPrima.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMateriaPrima.DataTables
{
    public class DtMovimento
    {
        public static DataTable Dt { get; set; }
        private static void SetColunas()
        {
            Dt = new DataTable();
            Dt.Columns.Add("Id", typeof(int));
            Dt.Columns.Add("Data", typeof(DateTime));
            Dt.Columns.Add("PesoEntrada", typeof(double));
            Dt.Columns.Add("PesoSaida", typeof(double));
            Dt.Columns.Add("Descricao", typeof(string));
            Dt.Columns.Add("TipoProcessoId", typeof(int));
            Dt.Columns.Add("TipoProcesso", typeof(string));
            Dt.Columns.Add("FuncionarioId", typeof(int));
            Dt.Columns.Add("Funcionario", typeof(string));
        }

        public static DataTable PreencherMovimento(IEnumerable<Movimento> movimentos)
        {
            SetColunas();
            foreach (var movimento in movimentos)
            {
                Dt.Rows.Add(
                    movimento.Id,
                    movimento.Data,
                    movimento.PesoEntrada,
                    movimento.PesoSaida,
                    movimento.Descricao,
                    movimento.TipoProcessoId,
                    movimento.TipoProcesso.Nome,
                    movimento.FuncionarioId,
                    movimento.Funcionario.Nome
                    );
            }
            return Dt;
        }


    }
}
