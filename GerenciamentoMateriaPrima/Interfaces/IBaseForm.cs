﻿using GerenciamentoMateriaPrima.Controller;

namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IBaseForm
    {
        public void ValidarNumero(object sender, KeyPressEventArgs e);
        public void Limpar();
        public void CarregarDataGridView(bool limpar);
        public void OcultarColunas(params string[] colunas);
        public void SetControlador<T>(T controller) where T : BaseController;
        public bool ValidarCampos();
    }
}
