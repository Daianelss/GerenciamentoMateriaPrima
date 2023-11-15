using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Services;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class MovimentoController
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

        public DataTable PreencherMovimento(IEnumerable<Movimento> movimentos)
        {
            return DtMovimento.PreencherMovimento(movimentos);
        }
        public IEnumerable<Movimento> ListarMovimento()
        {
            return _movimentoDal.ListarTodos();
        }
        public void AtualizarMovimento()
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

        public void SalvarMovimento()
        {
            if (string.IsNullOrEmpty(_iMovimento.Descricao) && (string.IsNullOrEmpty(_iMovimento.PesoEntrada) || string.IsNullOrEmpty(_iMovimento.PesoSaida)))
                throw new Exception("Verifique se o campo descrição e o campo entrada ou saida estão preenchidos");
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
        public object ListarTiposProcessos()
        {
            return _tipoProcessoDal.ListarTodos();
        }

        public object ListarFuncionarios()
        {
            return _funcionarioDal.ListarTodos();
        }

        public void GerarExcel(DataGridView dataGridView, string nomeArquivo, string nomePlanilha)
        {
            var servico = new PlanilhaService(nomeArquivo, nomePlanilha);

            servico.GerarPlanilhaDoDataGridView(dataGridView);
        }
    }
}
