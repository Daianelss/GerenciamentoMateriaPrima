using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMateriaPrima.DAL
{
    public class TipoProcessoDal : BaseDal<TipoProcesso>
    {
        public TipoProcessoDal(DbContext context) : base(context)
        {
        }
    }
}
