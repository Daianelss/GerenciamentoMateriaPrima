using GerenciamentoMateriaPrima.Model;

namespace GerenciamentoMateriaPrima.Entidades.DTO
{
    public class MovimentoMateriaPrimaDto : MovimentoMateriaPrima
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
