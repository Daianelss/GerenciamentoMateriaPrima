using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class TipoProcessoController : BaseController
    {
        private readonly ITipoProcesso _iTipoProcesso;
        private readonly TipoProcessoDal _tipoProcessoDal;

        public TipoProcessoController(ITipoProcesso tipoProcesso)
        {
            _iTipoProcesso = tipoProcesso;
            _tipoProcessoDal = new TipoProcessoDal(new GerenciamentoMateriaPrimaContext());
        }

        public override DataTable PreencherDataGridView<T>(IEnumerable<T> tipoProcessos)
        {
            return DtTipoProcesso.PreencherTipoProcesso(tipoProcessos);
        }

        public override IEnumerable<TipoProcesso> ListarTodos()
        {
            return _tipoProcessoDal.ListarTodos();
        }

        public override void Atualizar()
        {
            var tipoProcesso = new TipoProcesso
            {
                Id = Convert.ToInt32(_iTipoProcesso.Id),
                Nome = _iTipoProcesso.Nome,
                Descricao = _iTipoProcesso.Descricao,
                Status = Convert.ToInt32(_iTipoProcesso.Status)
            };
            _tipoProcessoDal.Atualizar(tipoProcesso);
        }

        public override void Salvar()
        {
            if (string.IsNullOrEmpty(_iTipoProcesso.Nome))
                throw new Exception("Necessário preencher nome do processo");
            var tipoProcesso = new TipoProcesso
            {
                Nome = _iTipoProcesso.Nome,
                Descricao = _iTipoProcesso.Descricao,
                Status = 1
            };
            _tipoProcessoDal.Salvar(tipoProcesso);
        }

        public override IEnumerable<BaseModel> ListarPorFiltro<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
