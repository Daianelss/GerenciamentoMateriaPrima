using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model.DAL;

namespace GerenciamentoMateriaPrima.Controller
{
    public class HomeController
    {
        private readonly IHome _iHome;
        private readonly MovimentoDal _movimentoDal;
        private readonly MovimentoMateriaPrimaDal _movimentoMateriaPrimaDal;

        public HomeController(IHome home)
        {
            _iHome = home;
            _movimentoDal = new MovimentoDal(new GerenciamentoMateriaPrimaContext());
            _movimentoMateriaPrimaDal = new MovimentoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }


        public void PreencherTotais()
        {
            double movimentos = _movimentoDal.ObterQuebra();
            var movimentosMateriaPrima = _movimentoMateriaPrimaDal.ListarTotais();


            if (movimentosMateriaPrima.Any())
            {
                _iHome.EntradaMateriaPrimaTotal =  movimentosMateriaPrima.Any(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Entrada)? movimentosMateriaPrima.FirstOrDefault(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Entrada).Total:0;
                _iHome.SaidaMateriaPrimaTotal = movimentosMateriaPrima.Any(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Saida) ? movimentosMateriaPrima.FirstOrDefault(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Saida).Total : 0;
                _iHome.QuebraBancaTotal = movimentos;
                _iHome.MateriaPrimaTotalNaoUtilizada = _iHome.EntradaMateriaPrimaTotal - _iHome.SaidaMateriaPrimaTotal - _iHome.QuebraBancaTotal;
            }
        }
    }
}
