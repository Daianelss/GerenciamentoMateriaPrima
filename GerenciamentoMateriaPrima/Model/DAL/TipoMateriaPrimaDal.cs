﻿using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.Model.DAL
{
    public class TipoMateriaPrimaDal : BaseDal<TipoMateriaPrima>
    {
        public TipoMateriaPrimaDal(DbContext context) : base(context)
        {
        }
    }
}
