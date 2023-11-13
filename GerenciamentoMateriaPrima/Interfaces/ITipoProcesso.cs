using GerenciamentoMateriaPrima.Controller;
using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface ITipoProcesso
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DataTable DtTipoProcesso { get; set; }

        public void SetControlador(TipoProcessoController controller);
    }
}
