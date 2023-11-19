using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;
using System.Text;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormTipoProcesso : Form, ITipoProcesso
    {
        public FormTipoProcesso()
        {
            InitializeComponent();
        }

        public TipoProcessoController Controlador { get; set; }
        #region Elemento Tela
        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }
        public string Descricao { get => txtDescricao.Text; set => txtDescricao.Text = value; }
        public bool Status { get => chkStatus.Checked; set => chkStatus.Checked = value; }
        #endregion

        #region Elemento de Controle
        public DataTable DtTipoProcesso { get; set; }
        public bool Editando { get; set; }
        #endregion

        public void SetControlador<T>(T controller) where T : BaseController
        {
            Controlador = controller as TipoProcessoController;
        }
        #region Acoes
        private void FormTipoProcesso_Load(object sender, EventArgs e)
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
                        throw new Exception($"Houve um erro ao tentar alterar o processo. {ex.Message}", ex);
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
                        throw new Exception($"Houve um erro ao tentar salvar o processo. {ex.Message}", ex);
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
        private void dtgTipoProcesso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;
            if (dtgTipoProcesso.SelectedRows.Count > 0)
            {
                Nome = dtgTipoProcesso.SelectedRows[0].Cells["Nome"].Value.ToString();
                Id = dtgTipoProcesso.SelectedRows[0].Cells["Id"].Value.ToString();
                Descricao = dtgTipoProcesso.SelectedRows[0].Cells["Descricao"].Value.ToString();
                Status = Convert.ToBoolean(Convert.ToInt32(dtgTipoProcesso.SelectedRows[0].Cells["StatusValor"].Value.ToString()));

            }
        }
        #endregion

        #region Metodos
        public void CarregarDataGridView()
        {
            Limpar();
            IEnumerable<TipoProcesso> tipoProcessos = Controlador.ListarTodos();
            DtTipoProcesso = Controlador.PreencherDataGridView(tipoProcessos);
            dtgTipoProcesso.DataSource = DtTipoProcesso;
            OcultarColunas("StatusValor");
        }
        public void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgTipoProcesso.Columns[coluna].Visible = false;

        }
        public void Limpar()
        {
            Id = string.Empty;
            Nome = string.Empty;
            Status = false;
            Descricao = string.Empty;
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
