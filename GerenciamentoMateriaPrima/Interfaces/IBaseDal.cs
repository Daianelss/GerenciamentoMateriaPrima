namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IBaseDal<T>
    {
        public T ListarPorId(int id);
        public List<T> ListarTodos();
        public bool Salvar(T item);
        public bool SalvarTodos(IEnumerable<T> itens);
        public bool Excluir(T item);
        public bool Atualizar(T item);
        public bool AtualizarTodos(IEnumerable<T> itens);
    }
}
