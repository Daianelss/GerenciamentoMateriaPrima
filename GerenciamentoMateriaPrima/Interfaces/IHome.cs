namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IHome
    {

        public double QuebraBancaTotal { get; set; }
        public double EntradaMateriaPrimaTotal { get; set; }
        public double SaidaMateriaPrimaTotal { get; set; }
        public double MateriaPrimaTotalNaoUtilizada { get; set; }
    }
}
