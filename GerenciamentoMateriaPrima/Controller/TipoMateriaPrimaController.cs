using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class TipoMateriaPrimaController
    {
        public ITipoMateriaPrima TipoMateriaPrima { get; set; }
        private readonly TipoMateriaPrimaDal _tipoMateriaPrimaDal;

        public TipoMateriaPrimaController(ITipoMateriaPrima tipoMateriaPrima)
        {
            TipoMateriaPrima = tipoMateriaPrima;
            _tipoMateriaPrimaDal = new TipoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }

        public void GravarTipoMateriaPrima(TipoMateriaPrima tipoMateriaPrima)
        {
            _tipoMateriaPrimaDal.Salvar(tipoMateriaPrima);
        }

        public DataTable PreencherTipoMateriaPrima(IEnumerable<TipoMateriaPrima> tipoMateriaPrimas)
        {
            return DtTipoMateriaPrima.PreencherTipoMateriaPrima(tipoMateriaPrimas);
        }

        public IEnumerable<TipoMateriaPrima> ListartipoMateriaPrimas()
        {
            return _tipoMateriaPrimaDal.ListarTodos();
        }

        public void AtualizartipoMateriaPrima(TipoMateriaPrima tipoMateriaPrima)
        {
            _tipoMateriaPrimaDal.Atualizar(tipoMateriaPrima);
        }

    }
}
