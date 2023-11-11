using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormFuncionario : Form, IFuncionario
    {
        public FuncionarioController FuncionarioControlador { get; set; }
        public FormFuncionario()
        {
            InitializeComponent();
        }
        public void SetControlador(FuncionarioController funcionarioControlador)
        {
            FuncionarioControlador = funcionarioControlador;
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
            dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblIdFuncionario.Text != "lblIdFuncionario")
            {
                var funcionario = new Funcionario { Id = int.Parse(lblIdFuncionario.Text), Nome = TxtNomeFuncionario.Text, Status = int.Parse(lblStatusFuncionario.Text) };
                FuncionarioControlador.AtualizarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);
            }

            else
            {

                var funcionario = new Funcionario { Nome = TxtNomeFuncionario.Text, Status = 0 };
                FuncionarioControlador.GravarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);

            }
            // dtgFuncionario.Update();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtNomeFuncionario.Clear();
            lblIdFuncionario.Text = "";
            lblStatusFuncionario.Text = "";
        }

        private void btnAtivarInativar_Click(object sender, EventArgs e)
        {
            if (lblStatusFuncionario.Text == "0")
            {
                var funcionario = new Funcionario { Id = int.Parse(lblIdFuncionario.Text), Nome = TxtNomeFuncionario.Text, Status = 1 };
                FuncionarioControlador.AtualizarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);
            }

            else
            {
                var funcionario = new Funcionario { Id = int.Parse(lblIdFuncionario.Text), Nome = TxtNomeFuncionario.Text, Status = 0 };
                FuncionarioControlador.AtualizarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);
            }


        }

        private void dtgFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selecionado = dtgFuncionario.Rows[e.RowIndex];
                lblIdFuncionario.Text = selecionado.Cells["Id"].Value.ToString();
                lblStatusFuncionario.Text = selecionado.Cells["Status"].Value.ToString();
                TxtNomeFuncionario.Text = selecionado.Cells["Nome"].Value.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
