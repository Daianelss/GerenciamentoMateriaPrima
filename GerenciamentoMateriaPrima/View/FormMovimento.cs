using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Helpers.Utils;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;
using System.Text;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormMovimento : Form, IMovimento
    {
        public FormMovimento()
        {
            InitializeComponent();
        }

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


        public void SetControlador<T>(T controller) where T : BaseController
        {
            Controlador = controller as MovimentoController;
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
        private void txtPesoEntrada_Leave(object sender, EventArgs e)
        {
            Validacao.FormatarCampoNumero(sender, e);

        }
        private void txtPesoSaida_Leave(object sender, EventArgs e)
        {
            Validacao.FormatarCampoNumero(sender, e);
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
            IEnumerable<Movimento> movimentos = Controlador.ListarTodos();
            DtMovimento = Controlador.PreencherDataGridView(movimentos);
            dtgMovimento.DataSource = DtMovimento;
            OcultarColunas("FuncionarioId", "TipoProcessoId");
        }
        public void CarregarTipoProcesso()
        {
            var dados = Controlador.ListarTiposProcessos();
            cmbProcesso.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProcesso.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        public bool ValidarCampos()
        {
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(PesoEntrada?.Trim()) || string.IsNullOrEmpty(PesoSaida?.Trim()))
                sb.AppendLine("É necessário o preenchimento do Peso de Entrada ou de Saída");

            if (string.IsNullOrEmpty(Descricao?.Trim()))
                sb.AppendLine("É necessário adicionar uma descrição");

            if (string.IsNullOrEmpty(FuncionarioId?.Trim()))
                sb.AppendLine("É necessário selecionar um funcionário");

            if (string.IsNullOrEmpty(TipoProcessoId?.Trim()))
                sb.AppendLine("É necessário selecionar o processo");

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
