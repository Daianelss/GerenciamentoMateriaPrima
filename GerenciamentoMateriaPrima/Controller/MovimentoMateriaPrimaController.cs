using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.Controller.Services;
using GerenciamentoMateriaPrima.Entidades.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class MovimentoMateriaPrimaController : BaseController
    {
        private readonly IMovimentoMateriaPrima _iMovimentoMateriaPrima;
        private readonly MovimentoMateriaPrimaDal _movimentoMateriaPrimaDal;
        private readonly TipoMateriaPrimaDal _tipoMateriaPrimaDal;

        public MovimentoMateriaPrimaController(IMovimentoMateriaPrima movimentoMateriaPrima)
        {
            _iMovimentoMateriaPrima = movimentoMateriaPrima;
            _movimentoMateriaPrimaDal = new MovimentoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
            _tipoMateriaPrimaDal = new TipoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }

        public override DataTable PreencherDataGridView<T>(IEnumerable<T> movimentoMateriaPrimas)
        {
            return DtMovimentoMateriaPrima.PreencherMovimentoMateriaPrima(movimentoMateriaPrimas);
        }
        public override IEnumerable<MovimentoMateriaPrima> ListarTodos()
        {
            return _movimentoMateriaPrimaDal.ListarTodos();
        }
        public override void Atualizar()
        {
            var movimentoMateriaPrima = new MovimentoMateriaPrima
            {
                Id = Convert.ToInt32(_iMovimentoMateriaPrima.Id),
                Peso = Convert.ToDouble(_iMovimentoMateriaPrima.Peso),
                Descricao = _iMovimentoMateriaPrima.Descricao,
                Data = Convert.ToDateTime(_iMovimentoMateriaPrima.Data),
                EntradaSaida = Convert.ToInt32(_iMovimentoMateriaPrima.Entrada),
                TipoMateriaPrimaId = Convert.ToInt32(_iMovimentoMateriaPrima.TipoMateriaPrimaId)
            };
            _movimentoMateriaPrimaDal.Atualizar(movimentoMateriaPrima);
        }

        public override void Salvar()
        {
            var movimentoMateriaPrima = new MovimentoMateriaPrima
            {
                Peso = Convert.ToDouble(_iMovimentoMateriaPrima.Peso),
                Descricao = _iMovimentoMateriaPrima.Descricao,
                Data = Convert.ToDateTime(_iMovimentoMateriaPrima.Data),
                EntradaSaida = Convert.ToInt32(_iMovimentoMateriaPrima.Entrada),
                TipoMateriaPrimaId = Convert.ToInt32(_iMovimentoMateriaPrima.TipoMateriaPrimaId)
            };
            _movimentoMateriaPrimaDal.Salvar(movimentoMateriaPrima);
        }

        public IEnumerable<TipoMateriaPrima> ListarTipoMateriaPrimas()
        {
            return _tipoMateriaPrimaDal.ListarTodos();
        }

        public void GerarExcel(DataGridView dataGridView, string nomeArquivo, string nomePlanilha)
        {
            var servico = new PlanilhaService(nomeArquivo, nomePlanilha);

            servico.GerarPlanilhaDoDataGridView(dataGridView);
        }


        public override IEnumerable<BaseModel> ListarPorFiltro()
        {
            throw new NotImplementedException();
        }
    }
}
