using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Helpers.Utils;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;
using System.Text;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormMovimentoMateriaPrima : Form, IMovimentoMateriaPrima
    {
        public FormMovimentoMateriaPrima()
        {
            InitializeComponent();
        }

        public MovimentoMateriaPrimaController Controlador { get; set; }
        #region Elementos de tela
        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public DateTime Data { get => dtpData.Value; set => dtpData.Value = value; }
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
        public void SetControlador<T>(T controller) where T : BaseController
        {
            Controlador = controller as MovimentoMateriaPrimaController;
        }

        #region Acoes
        private void FormMovimentoMateriaPrima_Load(object sender, EventArgs e)
        {
            CarregarTiposMateriaPrima();
            CarregarValoresDefault();
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
                        throw new Exception($"Houve um erro ao tentar alterar o Movimento. {ex.Message}", ex);
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
                        throw new Exception($"Houve um erro ao tentar salvar o Movimento. {ex.Message}", ex);
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
        private void dtgListaMovimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;
            if (dtgListaMovimento.SelectedRows.Count > 0)
            {
                Id = dtgListaMovimento.SelectedRows[0].Cells["Id"].Value.ToString();
                Data = Conversoes.ConverterTextoParaData(dtgListaMovimento.SelectedRows[0].Cells["Data"].Value.ToString(), "dd/MM/yyyy HH:mm:ss");
                Peso = dtgListaMovimento.SelectedRows[0].Cells["Peso"].Value.ToString();
                Descricao = dtgListaMovimento.SelectedRows[0].Cells["Descricao"].Value.ToString();
                Entrada = Convert.ToBoolean(Convert.ToInt32(dtgListaMovimento.SelectedRows[0].Cells["EntradaSaidaValor"].Value.ToString()));
                Saida = !Convert.ToBoolean(Convert.ToInt32(dtgListaMovimento.SelectedRows[0].Cells["EntradaSaidaValor"].Value.ToString()));
                TipoMateriaPrimaId = dtgListaMovimento.SelectedRows[0].Cells["TipoMateriaPrimaId"].Value.ToString();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPeso_Leave(object sender, EventArgs e)
        {
            Validacao.FormatarCampoNumero(sender, e);
        }
        #endregion

        #region Metodos
        public void Limpar()
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
            IEnumerable<MovimentoMateriaPrima> movimentoMateriaPrimas = Controlador.ListarTodos();
            DtMovimento = Controlador.PreencherDataGridView(movimentoMateriaPrimas);
            dtgListaMovimento.DataSource = DtMovimento;
            OcultarColunas("EntradaSaidaValor", "TipoMateriaPrimaId");
        }
        public void CarregarTiposMateriaPrima()
        {
            var dados = Controlador.ListarTipoMateriaPrimas();
            cmbTipoMateriaPrima.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoMateriaPrima.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoMateriaPrima.DataSource = dados;
            cmbTipoMateriaPrima.DisplayMember = "Nome";
            cmbTipoMateriaPrima.ValueMember = "Id";
            cmbTipoMateriaPrima.SelectedIndex = -1;
        }
        public void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgListaMovimento.Columns[coluna].Visible = false;
        }
        private void CarregarValoresDefault()
        {
            dtpData.Value = DateTime.Now;
        }
        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            Validacao.ValidarNumeros(sender, e);
        }

        #endregion

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                var arquivo = new SaveFileDialog
                {
                    Filter = "XLSX | *.xlsx",
                    Title = "Escolha o local e nome do arquivo para salvar!"
                };
                arquivo.ShowDialog();

                Controlador.GerarExcel(dtgListaMovimento, arquivo.FileName, "RelatorioMovimento");

                MessageBox.Show($"Planilha gerada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao tentar gerar o excel. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool ValidarCampos()
        {
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(Peso?.Trim()))
                sb.AppendLine("É necessário preencher o peso");

            if (string.IsNullOrEmpty(Descricao?.Trim()))
                sb.AppendLine("É necessário adicionar uma descrição");

            if (string.IsNullOrEmpty(TipoMateriaPrimaId?.Trim()))
                sb.AppendLine("É necessário selecionar o tipo de matéria prima");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
