﻿namespace GerenciamentoMateriaPrima.Interfaces
{
    public interface IBaseForm
    {
        public void ValidarNumero(object sender, KeyPressEventArgs e);
        public void Limpar();
        public void CarregarDataGridView();
        public void OcultarColunas(params string[] colunas);

    }
}
