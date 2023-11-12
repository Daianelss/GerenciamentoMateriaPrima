using GerenciamentoMateriaPrima.Controller;
using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IFuncionario
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public bool Status { get; set; }
        public DataTable DtFuncionario { get; set; }
        public void SetControlador(FuncionarioController controller);
    }
}
