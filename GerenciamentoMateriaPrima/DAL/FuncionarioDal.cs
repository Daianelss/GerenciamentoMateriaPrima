using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.DAL
{
    public class FuncionarioDal : BaseDal<Funcionario>
    {
        public FuncionarioDal(DbContext context) : base(context)
        {
        }
    }
}
