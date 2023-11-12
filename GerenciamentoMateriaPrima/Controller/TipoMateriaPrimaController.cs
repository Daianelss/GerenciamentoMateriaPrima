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
        private readonly ITipoMateriaPrima _iTipoMateriaPrima;
        private readonly TipoMateriaPrimaDal _tipoMateriaPrimaDal;

        public TipoMateriaPrimaController(ITipoMateriaPrima tipoMateriaPrima)
        {
            _iTipoMateriaPrima = tipoMateriaPrima;
            _tipoMateriaPrimaDal = new TipoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }

        public DataTable PreencherTipoMateriaPrima(IEnumerable<TipoMateriaPrima> tipoMateriaPrimas)
        {
            return DtTipoMateriaPrima.PreencherTipoMateriaPrima(tipoMateriaPrimas);
        }

        public IEnumerable<TipoMateriaPrima> ListarTipoMateriaPrimas()
        {
            return _tipoMateriaPrimaDal.ListarTodos();
        }

        public void AtualizarTipoMateriaPrima()
        {
            var tipoMateriaPrima = new TipoMateriaPrima
            {
                Id = Convert.ToInt32(_iTipoMateriaPrima.Id),
                Nome = _iTipoMateriaPrima.Nome,
                Descricao = _iTipoMateriaPrima.Descricao,
                Status = Convert.ToInt32(_iTipoMateriaPrima.Status)
            };

            _tipoMateriaPrimaDal.Atualizar(tipoMateriaPrima);
        }
        public void SalvarTipoMateriaPrima()
        {
            if (string.IsNullOrEmpty(_iTipoMateriaPrima.Nome))
                throw new Exception("Necessário preencher nome da materia prima");
            var tipoMateriaPrima = new TipoMateriaPrima
            {
                Nome = _iTipoMateriaPrima.Nome,
                Descricao = _iTipoMateriaPrima.Descricao,
                Status = 1
            };
            _tipoMateriaPrimaDal.Salvar(tipoMateriaPrima);
        }
    }
}