using GerenciamentoMateriaPrima.Model;

namespace GerenciamentoMateriaPrima.Entidades.DTO
{
    public  class MovimentoDto: Movimento
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
