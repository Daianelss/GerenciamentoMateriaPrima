using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IFuncionario : IBaseForm
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public bool Status { get; set; }
        public DataTable DtFuncionario { get; set; }
    }
}
