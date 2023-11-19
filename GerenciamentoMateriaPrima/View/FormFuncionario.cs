using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormFuncionario : Form, IFuncionario
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }
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

        #region Acoes
        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editando)
                {
                    try
                    {
                        Controlador.Atualizar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Houve um erro ao tentar alterar o Funcionário. {ex.Message}", ex);
                    }
                }
                else
                {
                    try
                    {
                        Controlador.Salvar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Houve um erro ao tentar salvar o Funcionário. {ex.Message}", ex);
                    }
                }

                CarregarDataGridView();
            }
            catch (Exception ex)
            {
                Editando = false;
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                Status = Convert.ToBoolean(Convert.ToInt32(dtgFuncionario.SelectedRows[0].Cells["StatusValor"].Value.ToString()));
            }
        }
        #endregion

        #region Metodos
        public void Limpar()
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
            var funcionarios = Controlador.ListarTodos() as IEnumerable<Funcionario>;
            DtFuncionario = Controlador.PreencherDataGridView(funcionarios);
            dtgFuncionario.DataSource = DtFuncionario;
            OcultarColunas("StatusValor");
        }
        public void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgFuncionario.Columns[coluna].Visible = false;
        }

        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }


        public void SetControlador<T>(T controller) where T : BaseController
        {
            Controlador = controller as FuncionarioController;
        }
        #endregion











    }
}
