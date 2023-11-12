using GerenciamentoMateriaPrima.Controller;
using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface ITipoMateriaPrima
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DataTable DtTipoMateriaPrima { get; set; }

        public void SetControlador(TipoMateriaPrimaController controller);
    }
}
