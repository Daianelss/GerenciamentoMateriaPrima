using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class TipoProcessoController
    {
        private readonly ITipoProcesso _iTipoProcesso;
        private readonly TipoProcessoDal _tipoProcessoDal;

        public TipoProcessoController(ITipoProcesso tipoProcesso)
        {
            _iTipoProcesso = tipoProcesso;
            _tipoProcessoDal = new TipoProcessoDal(new GerenciamentoMateriaPrimaContext());
        }

        public DataTable PreencherTipoProcesso(IEnumerable<TipoProcesso> tipoProcessos)
        {
            return DtTipoProcesso.PreencherTipoProcesso(tipoProcessos);
        }

        public IEnumerable<TipoProcesso> ListarTipoProcessos()
        {
            return _tipoProcessoDal.ListarTodos();
        }

        public void AtualizarTipoProcesso()
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

        public void SalvarTipoProcesso()
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








    }
}
