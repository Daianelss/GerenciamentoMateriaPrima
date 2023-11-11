using GerenciamentoMateriaPrima.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{
    public class BaseDal<T> : IBaseDal<T> where T : class
    {
        private readonly DbContext _context;
        public BaseDal(DbContext context)
        {
            _context = context;
        }

        public bool Atualizar(T item)
        {
            try
            {
                _context.Set<T>().Update(item);
                return _context.SaveChanges() > 0;

            }
            catch (Exception e)
            {

                throw new Exception("Não foi possível atualizar item!" + e.Message);
            }
        }

        public bool AtualizarTodos(IEnumerable<T> itens)
        {
            try
            {
                _context.Set<T>().UpdateRange(itens);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possível atualizar todos os itens!");
            }
        }

        public bool Excluir(T item)
        {
            try
            {
                _context.Set<T>().Remove(item);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possível excluir o item!");
            }
        }

        public T ListarPorId(int id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw new Exception("Não foi possível listar item!");
            }
        }

        public List<T> ListarTodos()
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possível listar todos itens!");
            }
        }

        public bool Salvar(T item)
        {
            try
            {
                _context.Set<T>().Add(item);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar item!");
            }
        }

        public bool SalvarTodos(IEnumerable<T> itens)
        {
            try
            {
                _context.Set<T>().AddRange(itens);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar os itens!");
            }
        }
    }
}
