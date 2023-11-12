using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormFuncionario : Form, IFuncionario
    {
        public FuncionarioController Controlador { get; set; }

        #region Elemento Tela
        public string Nome { get => txtNomeFuncionario.Text; set => txtNomeFuncionario.Text = value; }
        public string Id { get => txtIdFuncionario.Text; set => txtIdFuncionario.Text = value; }
        public bool Status { get => chkStatus.Checked; set => chkStatus.Checked = value; }
        #endregion

        #region Elementos de Controle
        public DataTable DtFuncionario { get; set; }
        public bool Editando { get; set; }
        #endregion



        public FormFuncionario()
        {
            InitializeComponent();
        }
        public void SetControlador(FuncionarioController funcionarioControlador)
        {
            Controlador = funcionarioControlador;
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                try
                {
                    Controlador.AtualizarFuncionario();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar alterar o funcionário. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    Controlador.SalvarFuncionario();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro ao tentar salvar o funcionário. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            Editando = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;

            if (dtgFuncionario.SelectedRows.Count > 0)
            {
                Nome = dtgFuncionario.SelectedRows[0].Cells["Nome"].Value.ToString();
                Id = dtgFuncionario.SelectedRows[0].Cells["Id"].Value.ToString();
                Status = Convert.ToBoolean(Convert.ToInt32(dtgFuncionario.SelectedRows[0].Cells["Status"].Value.ToString()));
            }
        }

        private void Limpar()
        {
            Nome = string.Empty;
            Id = string.Empty;
            Status = false;
            Editando = false;
            DtFuncionario = null;
        }

        public void CarregarDataGridView()
        {
            Limpar();
            IEnumerable<Funcionario> funcionarios = Controlador.ListarFuncionarios();
            DtFuncionario = Controlador.PreencherFuncionario(funcionarios);
            dtgFuncionario.DataSource = DtFuncionario;
        }
    }
}
