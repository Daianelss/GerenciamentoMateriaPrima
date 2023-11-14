using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormTipoProcesso : Form, ITipoProcesso
    {
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


        public FormTipoProcesso()
        {
            InitializeComponent();
        }

        public void SetControlador(TipoProcessoController controller)
        {
            Controlador = controller;
        }
        #region Acoes
        private void FormTipoProcesso_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                try
                {
                    Controlador.AtualizarTipoProcesso();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro ao tentar alterar o processo. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    Controlador.SalvarTipoProcesso();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar salvar o processo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void dtgTipoProcesso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando =true;
            if (dtgTipoProcesso.SelectedRows.Count >0)
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
            IEnumerable<TipoProcesso> tipoProcessos = Controlador.ListarTipoProcessos();
            DtTipoProcesso = Controlador.PreencherTipoProcesso(tipoProcessos);
            dtgTipoProcesso.DataSource = DtTipoProcesso;
            OcultarColunas("StatusValor");
        }

        private void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgTipoProcesso.Columns[coluna].Visible = false;

        }

        private void Limpar()
        {
            Id = string.Empty;
            Nome = string.Empty;
            Status = false;
            Descricao = string.Empty;
        }
        #endregion




    }
}
