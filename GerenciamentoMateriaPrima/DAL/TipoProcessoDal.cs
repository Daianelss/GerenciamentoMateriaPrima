using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{
    public class TipoProcessoDal : BaseDal<TipoProcesso>
    {
        public TipoProcessoDal(DbContext context) : base(context)
        {
        }
    }
}
