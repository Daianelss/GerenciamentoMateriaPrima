using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.Entidades.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class FuncionarioController : BaseController
    {
        private readonly IFuncionario _iFuncionario;
        private readonly FuncionarioDal _funcionarioDal;

        public FuncionarioController(IFuncionario funcionario)
        {
            _iFuncionario = funcionario;
            _funcionarioDal = new FuncionarioDal(new GerenciamentoMateriaPrimaContext());
        }

        public override DataTable PreencherDataGridView<T>(IEnumerable<T> funcionarios)
        {
            return DtFuncionario.PreencherFuncionarios(funcionarios);
        }

        public override IEnumerable<BaseModel> ListarTodos()
        {
            return _funcionarioDal.ListarTodos();
        }


        public override void Atualizar()
        {
            var funcionario = new Funcionario
            {
                Id = Convert.ToInt32(_iFuncionario.Id),
                Nome = _iFuncionario.Nome,
                Status = Convert.ToInt32(_iFuncionario.Status)
            };

            _funcionarioDal.Atualizar(funcionario);
        }

        public override void Salvar()
        {
            var funcionario = new Funcionario
            {
                Nome = _iFuncionario.Nome,
                Status = 1
            };

            _funcionarioDal.Salvar(funcionario);
        }

        public override IEnumerable<BaseModel> ListarPorFiltro<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
