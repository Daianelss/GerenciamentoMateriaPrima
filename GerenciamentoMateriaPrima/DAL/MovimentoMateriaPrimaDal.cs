using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{

    public class MovimentoMateriaPrimaDal : BaseDal<MovimentoMateriaPrima>
    {
        private readonly DbContext _context;
        public MovimentoMateriaPrimaDal(DbContext context) : base(context)
        {
            _context = context;
        }

        public override List<MovimentoMateriaPrima> ListarTodos()
        {
            try
            {
                return _context.Set<MovimentoMateriaPrima>()
                    .Include("TipoMateriaPrima")
                    .ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }
    }
}
