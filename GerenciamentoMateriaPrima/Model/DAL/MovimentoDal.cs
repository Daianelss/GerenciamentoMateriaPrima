using GerenciamentoMateriaPrima.Entidades.DTO;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.Model.DAL
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

        public double ObterQuebra()
        {
            try
            {
                return _context.Set<Movimento>()
                    .Sum(p => p.PesoEntrada - p.PesoSaida);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }

        public IEnumerable<BaseModel> ListarPorFiltro(MovimentoDto movimentoDto)
        {
            try
            {
                return _context.Set<Movimento>()
                    .Include("Funcionario")
                    .Include("TipoProcesso")
                    .Where(p => p.Data >= movimentoDto.DataInicio && p.Data <= movimentoDto.DataFim)
                    .Where(p => string.IsNullOrEmpty(movimentoDto.Descricao.Trim()) || p.Descricao.Contains(movimentoDto.Descricao.ToLower()))
                    .Where(p => movimentoDto.TipoProcessoId == 0 || p.TipoProcessoId == movimentoDto.TipoProcessoId)
                    .Where(p => movimentoDto.FuncionarioId == 0 || p.FuncionarioId == movimentoDto.FuncionarioId)
                    .ToList();
                    
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar todos itens!" + ex.Message);
            }
        }
    }
}
