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
                _iHome.EntradaMateriaPrimaTotal = movimentosMateriaPrima.FirstOrDefault(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Entrada).Total;
                _iHome.SaidaMateriaPrimaTotal = movimentosMateriaPrima.FirstOrDefault(p => p.TipoMovimentoMateriaPrima == Entidades.Enum.TipoMovimentoMateriaPrima.Saida).Total;
                _iHome.MateriaPrimaTotalNaoUtilizada = _iHome.EntradaMateriaPrimaTotal - _iHome.SaidaMateriaPrimaTotal;
                _iHome.QuebraBancaTotal = movimentos;
            }
        }
    }
}
