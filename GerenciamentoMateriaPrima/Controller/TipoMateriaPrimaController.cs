﻿using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.Entidades.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Model.DAL;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class TipoMateriaPrimaController : BaseController
    {
        private readonly ITipoMateriaPrima _iTipoMateriaPrima;
        private readonly TipoMateriaPrimaDal _tipoMateriaPrimaDal;

        public TipoMateriaPrimaController(ITipoMateriaPrima tipoMateriaPrima)
        {
            _iTipoMateriaPrima = tipoMateriaPrima;
            _tipoMateriaPrimaDal = new TipoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }

        public override DataTable PreencherDataGridView<T>(IEnumerable<T> tipoMateriaPrimas)
        {
            return DtTipoMateriaPrima.PreencherTipoMateriaPrima(tipoMateriaPrimas);
        }

        public override IEnumerable<TipoMateriaPrima> ListarTodos()
        {
            return _tipoMateriaPrimaDal.ListarTodos();
        }
        public override void Atualizar()
        {
            var tipoMateriaPrima = new TipoMateriaPrima
            {
                Id = Convert.ToInt32(_iTipoMateriaPrima.Id),
                Nome = _iTipoMateriaPrima.Nome,
                Descricao = _iTipoMateriaPrima.Descricao,
                Status = Convert.ToInt32(_iTipoMateriaPrima.Status)
            };

            _tipoMateriaPrimaDal.Atualizar(tipoMateriaPrima);
        }
        public override void Salvar()
        {
            var tipoMateriaPrima = new TipoMateriaPrima
            {
                Nome = _iTipoMateriaPrima.Nome,
                Descricao = _iTipoMateriaPrima.Descricao,
                Status = 1
            };
            _tipoMateriaPrimaDal.Salvar(tipoMateriaPrima);
        }

        public override IEnumerable<BaseModel> ListarPorFiltro()
        {
            throw new NotImplementedException();
        }
    }
}