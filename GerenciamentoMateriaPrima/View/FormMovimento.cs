using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.Utils;
using System.Data;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormMovimento : Form, IMovimento, IBaseForm
    {
        public MovimentoController Controlador { get; set; }

        #region Elemento Tela
        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public DateTime Data { get => dtsData.Value; set => dtsData.Value = value; }
        public string PesoEntrada { get => txtPesoEntrada.Text; set => txtPesoEntrada.Text = value; }
        public string PesoSaida { get => txtPesoSaida.Text; set => txtPesoSaida.Text = value; }
        public string Descricao { get => txtDescricao.Text; set => txtDescricao.Text = value; }
        public string TipoProcessoId
        {
            get => cmbProcesso.SelectedValue?.ToString();
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbProcesso.SelectedIndex = -1;
                else
                    cmbProcesso.SelectedValue = Convert.ToInt32(value);
            }
        }
        public string FuncionarioId
        {
            get => cmbFuncionario.SelectedValue?.ToString();
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbFuncionario.SelectedIndex = -1;
                else
                    cmbFuncionario.SelectedValue = Convert.ToInt32(value);
            }
        }
        #endregion

        #region Elemento de controle
        public DataTable DtMovimento { get; set; }
        public bool Editando { get; set; }
        #endregion

        public FormMovimento()
        {
            InitializeComponent();
        }
        public void SetControlador(MovimentoController controller)
        {
            Controlador = controller;
        }

        #region Acoes
        private void FormMovimento_Load(object sender, EventArgs e)
        {
            CarregarTipoProcesso();
            CarregarFuncionario();
            CarregarValoresDefault();
            CarregarDataGridView();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                try
                {
                    Controlador.AtualizarMovimento();
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
                    Controlador.SalvarMovimento();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Houve um erro ao tentar alterar o Movimento. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            CarregarDataGridView();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void dtgMovimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Editando = true;
            if (dtgMovimento.SelectedRows.Count > 0)
            {
                Id = dtgMovimento.SelectedRows[0].Cells["Id"].Value.ToString();
                Data = Conversoes.ConverterTextoParaData(dtgMovimento.SelectedRows[0].Cells["Data"].Value.ToString(), "dd/MM/yyyy HH:mm:ss");
                PesoEntrada = dtgMovimento.SelectedRows[0].Cells["PesoEntrada"].Value.ToString();
                PesoSaida = dtgMovimento.SelectedRows[0].Cells["PesoSaida"].Value.ToString();
                Descricao = dtgMovimento.SelectedRows[0].Cells["Descricao"].Value.ToString();
                TipoProcessoId = dtgMovimento.SelectedRows[0].Cells["TipoProcessoId"].Value.ToString();
                FuncionarioId = dtgMovimento.SelectedRows[0].Cells["FuncionarioId"].Value.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        public void Limpar()
        {
            Id = string.Empty;
            Data = DateTime.Now;
            PesoEntrada = string.Empty;
            PesoSaida = string.Empty;
            Descricao = string.Empty;
            Editando = false;
            TipoProcessoId = string.Empty;
            FuncionarioId = string.Empty;
            DtMovimento = null;
            cmbFuncionario.SelectedIndex = -1;
            cmbProcesso.SelectedIndex = -1;
        }
        public void CarregarDataGridView()
        {
            Limpar();
            IEnumerable<Movimento> movimentos = Controlador.ListarMovimento();
            DtMovimento = Controlador.PreencherMovimento(movimentos);
            dtgMovimento.DataSource = DtMovimento;
            OcultarColunas("FuncionarioId", "TipoProcessoId");
        }
        public void CarregarTipoProcesso()
        {
            var dados = Controlador.ListarTiposProcessos();
            cmbProcesso.DataSource = dados;
            cmbProcesso.DisplayMember = "Nome";
            cmbProcesso.ValueMember = "Id";
            cmbProcesso.SelectedIndex = -1;
        }
        public void CarregarFuncionario()
        {
            var dados = Controlador.ListarFuncionarios();
            cmbFuncionario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbFuncionario.DataSource = dados;
            cmbFuncionario.DisplayMember = "Nome";
            cmbFuncionario.ValueMember = "Id";
            cmbFuncionario.SelectedIndex = -1;

        }
        public void OcultarColunas(params string[] colunas)
        {
            foreach (var coluna in colunas)
                dtgMovimento.Columns[coluna].Visible = false;
        }
        private void CarregarValoresDefault()
        {
            dtsData.Value = DateTime.Now;
        }
        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            Validacao.ValidarNumeros(sender, e);
        }
        #endregion

        private void txtPesoEntrada_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox?.Text))
                textBox.Text = "0,00";
            else if (textBox.Text.LastOrDefault() == ',')
                textBox.Text = Convert.ToDouble(textBox.Text + '0').ToString("F2");
            else
                textBox.Text = Convert.ToDouble(textBox.Text).ToString("F2");

        }

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

                Controlador.GerarExcel(dtgMovimento, arquivo.FileName, "RelatorioMovimento");

                MessageBox.Show($"Planilha gerada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao tentar gerar o excel. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
