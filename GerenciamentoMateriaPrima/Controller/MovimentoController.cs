using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.Controller.Services;
using GerenciamentoMateriaPrima.Entidades.DataTables;
using GerenciamentoMateriaPrima.Entidades.DTO;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class MovimentoController : BaseController
    {
        private readonly IMovimento _iMovimento;
        private readonly MovimentoDal _movimentoDal;
        private readonly TipoProcessoDal _tipoProcessoDal;
        private readonly FuncionarioDal _funcionarioDal;

        public MovimentoController(IMovimento movimento)
        {
            _iMovimento = movimento;
            _movimentoDal = new MovimentoDal(new GerenciamentoMateriaPrimaContext());
            _tipoProcessoDal = new TipoProcessoDal(new GerenciamentoMateriaPrimaContext());
            _funcionarioDal = new FuncionarioDal(new GerenciamentoMateriaPrimaContext());
        }

        public override DataTable PreencherDataGridView<T>(IEnumerable<T> movimentos)
        {
            return DtMovimento.PreencherMovimento(movimentos);
        }
        public override IEnumerable<Movimento> ListarTodos()
        {
            return _movimentoDal.ListarTodos();
        }

        public override void Atualizar()
        {
            var movimento = new Movimento
            {
                Id = Convert.ToInt32(_iMovimento.Id),
                Data = Convert.ToDateTime(_iMovimento.Data),
                PesoEntrada = Convert.ToDouble(_iMovimento.PesoEntrada),
                PesoSaida = Convert.ToDouble(_iMovimento.PesoSaida),
                Descricao = _iMovimento.Descricao,
                TipoProcessoId = Convert.ToInt32(_iMovimento.TipoProcessoId),
                FuncionarioId = Convert.ToInt32(_iMovimento.FuncionarioId)
            };
            _movimentoDal.Atualizar(movimento);
        }

        public override void Salvar()
        {
            var movimento = new Movimento
            {
                Data = Convert.ToDateTime(_iMovimento.Data),
                PesoEntrada = Convert.ToDouble(_iMovimento.PesoEntrada),
                PesoSaida = Convert.ToDouble(_iMovimento.PesoSaida),
                Descricao = _iMovimento.Descricao,
                TipoProcessoId = Convert.ToInt32(_iMovimento.TipoProcessoId),
                FuncionarioId = Convert.ToInt32(_iMovimento.FuncionarioId)
            };
            _movimentoDal.Salvar(movimento);
        }
        public IEnumerable<TipoProcesso> ListarTiposProcessos()
        {
            return _tipoProcessoDal.ListarTodos();
        }

        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return _funcionarioDal.ListarTodos();
        }

        public void GerarExcel(DataGridView dataGridView, string nomeArquivo, string nomePlanilha)
        {
            var servico = new PlanilhaService(nomeArquivo, nomePlanilha);

            servico.GerarPlanilhaDoDataGridView(dataGridView);
        }

        public override IEnumerable<BaseModel> ListarPorFiltro()
        {
            var movimentoDto = new MovimentoDto
            {
                DataInicio = _iMovimento.DataInicio,
                DataFim = _iMovimento.DataFim,
                Descricao = _iMovimento.Descricao,
                FuncionarioId = Convert.ToInt32(_iMovimento.FuncionarioId),
                TipoProcessoId = Convert.ToInt32(_iMovimento.TipoProcessoId),
            };

            return _movimentoDal.ListarPorFiltro(movimentoDto);
        }
    }
}
