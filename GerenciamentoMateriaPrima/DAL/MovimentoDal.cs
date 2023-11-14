using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{
    public class MovimentoDal : BaseDal<Movimento>
    {
        private readonly DbContext _context;
        public MovimentoDal(DbContext context) : base(context)
        {
            _context = context;
        }
        public override List<Movimento> ListarTodos()
        {
            try
            {
                return _context.Set<Movimento>()
                    .Include("Funcionario")
                    .Include("TipoProcesso")
                    .ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }

    }
}
