using GerenciamentoMateriaPrima.Controller;
using System.Data;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IMovimentoMateriaPrima
    {
        #region Elementos de Tela
        public string Id { get; set; }
        public DateTime Data { get; set; }
        public string Peso { get; set; }
        public string Descricao { get; set; }
        public bool Entrada { get; set; }
        public string TipoMateriaPrimaId { get; set; }
        #endregion

        #region Elementos de Controle
        public DataTable DtMovimento { get; set; }
        public bool Editando { get; set; }
        #endregion
        public void SetControlador(MovimentoMateriaPrimaController controller, TipoMateriaPrimaController ControlleTipoMateriaPrima);
    }
}
