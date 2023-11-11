using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{
    public class TipoMateriaPrimaDal : BaseDal<TipoMateriaPrima>
    {
        public TipoMateriaPrimaDal(DbContext context) : base(context)
        {
        }
    }
}
