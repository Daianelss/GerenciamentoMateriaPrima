using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public abstract class BaseController
    {
        public abstract IEnumerable<BaseModel> ListarTodos();
        public abstract IEnumerable<BaseModel> ListarPorFiltro<T>(T item) where T : BaseModel;
        public abstract void Atualizar();
        public abstract void Salvar();
        public abstract DataTable PreencherDataGridView<T>(IEnumerable<T> listaItens) where T : BaseModel;
    }
}
