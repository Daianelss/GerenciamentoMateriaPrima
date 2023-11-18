using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface ITipoProcesso : IBaseForm
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DataTable DtTipoProcesso { get; set; }
    }
}
