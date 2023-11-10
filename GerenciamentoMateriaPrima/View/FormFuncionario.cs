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
            var funcionario = new Funcionario { Nome = TxtNomeFuncionario.Text, Status = 0 };
            FuncionarioControlador.GravarFuncionario(funcionario);
            IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
            dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);

            // dtgFuncionario.Update();
        }
    }
}
