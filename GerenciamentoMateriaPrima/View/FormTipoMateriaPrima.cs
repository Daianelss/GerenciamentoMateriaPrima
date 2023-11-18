using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormTipoMateriaPrima : Form, ITipoMateriaPrima
    {
        public FormTipoMateriaPrima()
        {
            InitializeComponent();
        }
        public TipoMateriaPrimaController Controlador { get; set; }

        #region Elemento Tela
        public string Id { get => txtIdTipoMateriaPrima.Text; set => txtIdTipoMateriaPrima.Text = value; }
        public string Nome { get => txtNomeTipoMateriaPrima.Text; set => txtNomeTipoMateriaPrima.Text = value; }
        public string Descricao { get => txtDescricaoTipoMateriaPrima.Text; set => txtDescricaoTipoMateriaPrima.Text = value; }
        public bool Status { get => chkStatus.Checked; set => chkStatus.Checked = value; }
        #endregion

        #region Elementos de Controle
        public DataTable DtTipoMateriaPrima { get; set; }
        public bool Editando { get; set; }
        #endregion

        public void SetControlador<T>(T controller) where T : BaseController
        {
            Controlador = controller as TipoMateriaPrimaController;
        }

        #region Acoes
        private void FormTipoMateriaPrima_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                try
                {
                    Controlador.Atualizar();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar alterar a Materia Prima. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    Controlador.Salvar();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar salvar a Materia Prima. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void dtgTipoMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;
            if (dtgTipoMateriaPrima.SelectedRows.Count > 0)
            {
                Nome = dtgTipoMateriaPrima.SelectedRows[0].Cells["Nome"].Value.ToString();
                Id = dtgTipoMateriaPrima.SelectedRows[0].Cells["Id"].Value.ToString();
                Descricao = dtgTipoMateriaPrima.SelectedRows[0].Cells["Descricao"].Value.ToString();
                Status = Convert.ToBoolean(Convert.ToInt32(dtgTipoMateriaPrima.SelectedRows[0].Cells["StatusValor"].Value.ToString()));

            }
        }
        #endregion

        #region Metodos
        public void Limpar()
        {
            Nome = string.Empty;
            Id = string.Empty;
            Status = false;
            Descricao = string.Empty;

        }
        public void CarregarDataGridView()
        {
            Limpar();
            IEnumerable<TipoMateriaPrima> tipoMateriaPrimas = Controlador.ListarTodos();
            DtTipoMateriaPrima = Controlador.PreencherDataGridView(tipoMateriaPrimas);
            dtgTipoMateriaPrima.DataSource = DtTipoMateriaPrima;
            OcultarColunas("StatusValor");
        }
        public void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgTipoMateriaPrima.Columns[coluna].Visible = false;
        }

        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
