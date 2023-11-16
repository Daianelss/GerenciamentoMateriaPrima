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

        public virtual bool Atualizar(T item)
        {
            try
            {
                _context.Set<T>().Update(item);
                return Persistir(item);

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível atualizar item!" + e.Message);
            }
        }

        public virtual bool AtualizarTodos(IEnumerable<T> itens)
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

        public virtual bool Excluir(T item)
        {
            try
            {
                _context.Set<T>().Remove(item);
                return Persistir(item);
            }
            catch (Exception)
            {

                throw new Exception("Não foi possível excluir o item!");
            }
        }

        public virtual T ListarPorId(int id)
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

        public virtual List<T> ListarTodos()
        {
            try
            {
                var teste =  _context.Set<T>();
                return teste.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }

        public virtual bool Salvar(T item)
        {
            try
            {
                _context.Set<T>().Add(item);
                return Persistir(item);
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar item!");
            }
        }

        public virtual bool SalvarTodos(IEnumerable<T> itens)
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

        public virtual bool Persistir(T item)
        {
            bool retorno = _context.SaveChanges() > 0;
            _context.Set<T>().Entry(item).State = EntityState.Detached;
            return retorno;
        }
    }
}
