using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMateriaPrima.DAL
{

    internal class MovimentoMateriaPrimaDal : BaseDal<MovimentoMateriaPrima>
    {
        public MovimentoMateriaPrimaDal(DbContext context) : base(context)
        {
        }
    }
}
