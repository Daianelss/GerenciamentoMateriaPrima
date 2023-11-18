using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IMovimento : IBaseForm
    {
        public string Id { get; set; }
        public DateTime Data { get; set; }
        public string PesoEntrada { get; set; }
        public string PesoSaida { get; set; }
        public string Descricao { get; set; }
        public string TipoProcessoId { get; set; }
        public string FuncionarioId { get; set; }

        public DataTable DtMovimento { get; set; }
        public bool Editando { get; set; }
    }
}
