using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;
using System.Globalization;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormMovimentoMateriaPrima : Form, IMovimentoMateriaPrima
    {
        public MovimentoMateriaPrimaController Controlador { get; set; }
        public TipoMateriaPrimaController ControladorTipoMateriaPrima { get; set; }
        #region Elementos de tela
        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public DateTime Data { get => dtData.Value; set => dtData.Value = value; }
        public string Peso { get => txtPeso.Text; set => txtPeso.Text = value; }
        public string Descricao { get => txtDescricao.Text; set => txtDescricao.Text = value; }
        public bool Entrada { get => rdbEntrada.Checked; set => rdbEntrada.Checked = value; }
        public bool Saida { get => rdbSaida.Checked; set => rdbSaida.Checked = value; }
        public string TipoMateriaPrimaId
        {
            get => cmbTipoMateriaPrima.SelectedValue?.ToString();
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbTipoMateriaPrima.SelectedIndex = -1;
                else
                    cmbTipoMateriaPrima.SelectedValue = Convert.ToInt32(value);
            }
        }
        #endregion

        #region Elementos de Controle
        public DataTable DtMovimento { get; set; }
        public bool Editando { get; set; }
        #endregion
        public FormMovimentoMateriaPrima()
        {
            InitializeComponent();
        }
        public void SetControlador(MovimentoMateriaPrimaController controller, TipoMateriaPrimaController ControlleTipoMateriaPrima)
        {
            Controlador = controller;
            ControladorTipoMateriaPrima = ControlleTipoMateriaPrima;

        }
        private void FormMovimentoMateriaPrima_Load(object sender, EventArgs e)
        {
            CarregarTiposMateriaPrima();
            CarregarValoresDefault();
            CarregarDataGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                try
                {
                    Controlador.AtualizarMovimentoMateriaPrima();
                    CarregarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro ao tentar alterar o Movimento. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                try
                {
                    Controlador.SalvarMovimentoMateriaPrima();
                    CarregarDataGridView();

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar salvar o Movimento. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgListaMovimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;
            if (dtgListaMovimento.SelectedRows.Count > 0)
            {
                Id = dtgListaMovimento.SelectedRows[0].Cells["Id"].Value.ToString();
                Data = ConverterTextoParaData(dtgListaMovimento.SelectedRows[0].Cells["Data"].Value.ToString(), "dd/MM/yyyy HH:mm:ss");
                Peso = dtgListaMovimento.SelectedRows[0].Cells["Peso"].Value.ToString();
                Descricao = dtgListaMovimento.SelectedRows[0].Cells["Descricao"].Value.ToString();
                Entrada = Convert.ToBoolean(Convert.ToInt32(dtgListaMovimento.SelectedRows[0].Cells["EntradaSaidaValor"].Value.ToString()));
                Saida = !Convert.ToBoolean(Convert.ToInt32(dtgListaMovimento.SelectedRows[0].Cells["EntradaSaidaValor"].Value.ToString()));
                TipoMateriaPrimaId = dtgListaMovimento.SelectedRows[0].Cells["TipoMateriaPrimaId"].Value.ToString();
            }
        }
        private void Limpar()
        {
            Id = string.Empty;
            Data = DateTime.Now;
            Peso = string.Empty;
            Descricao = string.Empty;
            Editando = false;
            Entrada = true;
            TipoMateriaPrimaId = string.Empty;
            DtMovimento = null;
            cmbTipoMateriaPrima.SelectedIndex = -1;
        }
        public void CarregarDataGridView()
        {
            Limpar();
            IEnumerable<MovimentoMateriaPrima> movimentoMateriaPrimas = Controlador.ListarMovimentoMateriaPrima();
            DtMovimento = Controlador.PreencherMovimentoMateriaPrima(movimentoMateriaPrimas);
            dtgListaMovimento.DataSource = DtMovimento;
            OcultarColunas("EntradaSaidaValor");
        }

        public void CarregarTiposMateriaPrima()
        {
            var dados = ControladorTipoMateriaPrima.ListarTipoMateriaPrimas();
            cmbTipoMateriaPrima.DataSource = dados;
            cmbTipoMateriaPrima.DisplayMember = "Nome";
            cmbTipoMateriaPrima.ValueMember = "Id";
            cmbTipoMateriaPrima.SelectedIndex = -1;
        }

        public void SetControlador(MovimentoMateriaPrimaController controller)
        {
            Controlador = controller;
        }

        private void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgListaMovimento.Columns[coluna].Visible = false;
        }

        private DateTime ConverterTextoParaData(string data, string padrao)
        {

            try
            {
                return DateTime.ParseExact(data, padrao, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }

        private void CarregarValoresDefault()
        {
            dtData.Value = DateTime.Now;
        }
    }
}
