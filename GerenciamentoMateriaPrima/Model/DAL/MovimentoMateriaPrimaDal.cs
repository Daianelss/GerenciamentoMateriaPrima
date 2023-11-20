using GerenciamentoMateriaPrima.Entidades.DTO;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.Model.DAL
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

        public IEnumerable<BaseModel> ListarPorFiltro(MovimentoMateriaPrimaDto movimentoMateriaPrimaDto)
        {
            try
            {
                return _context.Set<MovimentoMateriaPrima>()
                    .Include("TipoMateriaPrima")
                    .Where(p => p.Data >= movimentoMateriaPrimaDto.DataInicio && p.Data <= movimentoMateriaPrimaDto.DataFim)
                    .Where(p => string.IsNullOrEmpty(movimentoMateriaPrimaDto.Descricao.Trim()) || p.Descricao.Contains(movimentoMateriaPrimaDto.Descricao.ToLower()))
                    .Where(p => movimentoMateriaPrimaDto.TipoMateriaPrimaId == 0 || p.TipoMateriaPrimaId == movimentoMateriaPrimaDto.TipoMateriaPrimaId)
                    .ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }



        public List<TotaisMovimentoMateriaPrima> ListarTotais()
        {
            try
            {
                return _context.Set<MovimentoMateriaPrima>()
                    .GroupBy(p => p.EntradaSaida)
                    .Select(p => new TotaisMovimentoMateriaPrima { EntradaSaida = p.Key, Total = p.Sum(s => s.Peso) }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }
    }
}
