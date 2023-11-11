using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class FuncionarioController
    {
        public IFuncionario Funcionario { get; set; }
        private readonly FuncionarioDal _funcionarioDal;

        public FuncionarioController(IFuncionario funcionario)
        {
            Funcionario = funcionario;
            _funcionarioDal = new FuncionarioDal(new GerenciamentoMateriaPrimaContext());
        }

        public void GravarFuncionario(Funcionario funcionario)
        {
            _funcionarioDal.Salvar(funcionario);
        }

        public DataTable PreencherFuncionario(IEnumerable<Funcionario> funcionarios)
        {
            return DtFuncionario.PreencherFuncionarios(funcionarios);
        }

        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return _funcionarioDal.ListarTodos();
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            _funcionarioDal.Atualizar(funcionario);
        }

    }
}
