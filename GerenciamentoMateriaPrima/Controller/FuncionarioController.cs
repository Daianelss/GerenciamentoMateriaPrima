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
        private readonly IFuncionario _iFuncionario;
        private readonly FuncionarioDal _funcionarioDal;

        public FuncionarioController(IFuncionario funcionario)
        {
            _iFuncionario = funcionario;
            _funcionarioDal = new FuncionarioDal(new GerenciamentoMateriaPrimaContext());
        }

        public DataTable PreencherFuncionario(IEnumerable<Funcionario> funcionarios)
        {
            return DtFuncionario.PreencherFuncionarios(funcionarios);
        }

        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return _funcionarioDal.ListarTodos();
        }


        public void AtualizarFuncionario()
        {
            var funcionario = new Funcionario
            {
                Id = Convert.ToInt32(_iFuncionario.Id),
                Nome = _iFuncionario.Nome,
                Status = Convert.ToInt32(_iFuncionario.Status)
            };

            _funcionarioDal.Atualizar(funcionario);
        }

        public void SalvarFuncionario()
        {
            if (string.IsNullOrEmpty(_iFuncionario.Nome))
                throw new Exception("Necessário preencher nome de funcionário");

            var funcionario = new Funcionario
            {
                Nome = _iFuncionario.Nome,
                Status = 1
            };

            _funcionarioDal.Salvar(funcionario);
        }
    }
}
