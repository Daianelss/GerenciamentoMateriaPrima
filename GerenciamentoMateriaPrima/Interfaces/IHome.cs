using GerenciamentoMateriaPrima.Controller;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IHome
    {

        public string QuebraBancaTotal { get; set; }
        public string EntradaMateriaPrimaTotal { get; set; }
        public string SaidaMateriaPrimaTotal { get; set; }
        public string MateriaPrimaTotalNaoUtilizada { get; set; }

        public void SetControlador(HomeController controller);
    }
}
