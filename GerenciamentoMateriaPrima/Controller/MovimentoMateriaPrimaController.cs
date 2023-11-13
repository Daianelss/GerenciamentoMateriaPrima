﻿using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class MovimentoMateriaPrimaController
    {
        private readonly IMovimentoMateriaPrima _iMovimentoMateriaPrima;
        private readonly MovimentoMateriaPrimaDal _movimentoMateriaPrimaDal;

        public MovimentoMateriaPrimaController(IMovimentoMateriaPrima movimentoMateriaPrima)
        {
            _iMovimentoMateriaPrima = movimentoMateriaPrima;
            _movimentoMateriaPrimaDal = new MovimentoMateriaPrimaDal(new GerenciamentoMateriaPrimaContext());
        }

        public DataTable PreencherMovimentoMateriaPrima(IEnumerable<MovimentoMateriaPrima> movimentoMateriaPrimas)
        {
            return DtMovimentoMateriaPrima.PreencherMovimentoMateriaPrima(movimentoMateriaPrimas);
        }
        public IEnumerable<MovimentoMateriaPrima> ListarMovimentoMateriaPrima()
        {
            return _movimentoMateriaPrimaDal.ListarTodos();
        }
        public void AtualizarMovimentoMateriaPrima()
        {
            var movimentoMateriaPrima = new MovimentoMateriaPrima
            {
                Id = Convert.ToInt32(_iMovimentoMateriaPrima.Id),
                Peso = Convert.ToDouble(_iMovimentoMateriaPrima.Peso),
                Descricao = _iMovimentoMateriaPrima.Descricao,
                Data = Convert.ToDateTime(_iMovimentoMateriaPrima.Data),
                EntradaSaida = Convert.ToInt32(_iMovimentoMateriaPrima.Entrada),
                TipoMateriaPrimaId = Convert.ToInt32(_iMovimentoMateriaPrima.TipoMateriaPrimaId)
            };
            _movimentoMateriaPrimaDal.Atualizar(movimentoMateriaPrima);
        }

        public void SalvarMovimentoMateriaPrima()
        {
            if (string.IsNullOrEmpty(_iMovimentoMateriaPrima.Descricao))
                throw new Exception("Necessário Preencher Todos os dados");

            var movimentoMateriaPrima = new MovimentoMateriaPrima
            {
                Peso = Convert.ToDouble(_iMovimentoMateriaPrima.Peso),
                Descricao = _iMovimentoMateriaPrima.Descricao,
                Data = Convert.ToDateTime(_iMovimentoMateriaPrima.Data),
                EntradaSaida = Convert.ToInt32(_iMovimentoMateriaPrima.Entrada),
                TipoMateriaPrimaId = Convert.ToInt32(_iMovimentoMateriaPrima.TipoMateriaPrimaId)
            };
            _movimentoMateriaPrimaDal.Salvar(movimentoMateriaPrima);
        }

    }
}