using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;
using System.Text;

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
            try
            {
                if (Editando)
                {
                    try
                    {
                        if (!ValidarCampos())
                            return;

                        Controlador.Atualizar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Houve um erro ao tentar alterar a Matéria Prima. {ex.Message}", ex);
                    }
                }
                else
                {
                    try
                    {
                        if (!ValidarCampos())
                            return;

                        Controlador.Salvar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Houve um erro ao tentar salvar a Matéria Prima. {ex.Message}", ex);
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

        public bool ValidarCampos()
        {
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(Nome?.Trim()))
                sb.AppendLine("Campo Nome é Obrigatório");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        #endregion
    }
}
