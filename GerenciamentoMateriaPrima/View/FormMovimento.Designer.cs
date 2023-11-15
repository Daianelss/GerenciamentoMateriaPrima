namespace GerenciamentoMateriaPrima.View
{
    partial class FormMovimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel panFundo;
            panGrid = new Panel();
            dtgMovimento = new DataGridView();
            panBotoes = new Panel();
            btnRelatorio = new Button();
            btnVoltar = new Button();
            panCadastro = new Panel();
            btnLimpar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            lblProcesso = new Label();
            cmbProcesso = new ComboBox();
            btnSalvar = new Button();
            txtPesoSaida = new TextBox();
            txtPesoEntrada = new TextBox();
            lblPesoSaida = new Label();
            lblPesoEntrada = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            dtsData = new DateTimePicker();
            lblData = new Label();
            cmbFuncionario = new ComboBox();
            lblFuncionario = new Label();
            panFundo = new Panel();
            panFundo.SuspendLayout();
            panGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMovimento).BeginInit();
            panBotoes.SuspendLayout();
            panCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panFundo
            // 
            panFundo.Controls.Add(panGrid);
            panFundo.Controls.Add(panBotoes);
            panFundo.Controls.Add(panCadastro);
            panFundo.Dock = DockStyle.Fill;
            panFundo.Location = new Point(0, 0);
            panFundo.Name = "panFundo";
            panFundo.Size = new Size(1184, 621);
            panFundo.TabIndex = 0;
            // 
            // panGrid
            // 
            panGrid.Controls.Add(dtgMovimento);
            panGrid.Dock = DockStyle.Fill;
            panGrid.Location = new Point(0, 179);
            panGrid.Name = "panGrid";
            panGrid.Padding = new Padding(20);
            panGrid.Size = new Size(1184, 377);
            panGrid.TabIndex = 4;
            // 
            // dtgMovimento
            // 
            dtgMovimento.AllowUserToAddRows = false;
            dtgMovimento.AllowUserToDeleteRows = false;
            dtgMovimento.AllowUserToResizeColumns = false;
            dtgMovimento.AllowUserToResizeRows = false;
            dtgMovimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMovimento.Dock = DockStyle.Fill;
            dtgMovimento.Location = new Point(20, 20);
            dtgMovimento.MultiSelect = false;
            dtgMovimento.Name = "dtgMovimento";
            dtgMovimento.ReadOnly = true;
            dtgMovimento.RowTemplate.Height = 25;
            dtgMovimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMovimento.Size = new Size(1144, 337);
            dtgMovimento.TabIndex = 0;
            dtgMovimento.CellClick += dtgMovimento_CellClick;
            // 
            // panBotoes
            // 
            panBotoes.Controls.Add(btnRelatorio);
            panBotoes.Controls.Add(btnVoltar);
            panBotoes.Dock = DockStyle.Bottom;
            panBotoes.Location = new Point(0, 556);
            panBotoes.Name = "panBotoes";
            panBotoes.Size = new Size(1184, 65);
            panBotoes.TabIndex = 2;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorio.Location = new Point(838, 6);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(160, 50);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(1004, 6);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(160, 50);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panCadastro
            // 
            panCadastro.Controls.Add(btnLimpar);
            panCadastro.Controls.Add(txtId);
            panCadastro.Controls.Add(lblId);
            panCadastro.Controls.Add(lblProcesso);
            panCadastro.Controls.Add(cmbProcesso);
            panCadastro.Controls.Add(btnSalvar);
            panCadastro.Controls.Add(txtPesoSaida);
            panCadastro.Controls.Add(txtPesoEntrada);
            panCadastro.Controls.Add(lblPesoSaida);
            panCadastro.Controls.Add(lblPesoEntrada);
            panCadastro.Controls.Add(txtDescricao);
            panCadastro.Controls.Add(lblDescricao);
            panCadastro.Controls.Add(dtsData);
            panCadastro.Controls.Add(lblData);
            panCadastro.Controls.Add(cmbFuncionario);
            panCadastro.Controls.Add(lblFuncionario);
            panCadastro.Dock = DockStyle.Top;
            panCadastro.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panCadastro.Location = new Point(0, 0);
            panCadastro.Name = "panCadastro";
            panCadastro.Size = new Size(1184, 179);
            panCadastro.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(832, 112);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 50);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(54, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(85, 36);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(20, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 30);
            lblId.TabIndex = 3;
            lblId.Text = "Id:";
            // 
            // lblProcesso
            // 
            lblProcesso.AutoSize = true;
            lblProcesso.Location = new Point(20, 72);
            lblProcesso.Name = "lblProcesso";
            lblProcesso.Size = new Size(104, 30);
            lblProcesso.TabIndex = 13;
            lblProcesso.Text = "Processo:";
            // 
            // cmbProcesso
            // 
            cmbProcesso.FormattingEnabled = true;
            cmbProcesso.Location = new Point(133, 68);
            cmbProcesso.Name = "cmbProcesso";
            cmbProcesso.Size = new Size(397, 38);
            cmbProcesso.TabIndex = 12;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(1001, 112);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 50);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPesoSaida
            // 
            txtPesoSaida.Location = new Point(977, 66);
            txtPesoSaida.Name = "txtPesoSaida";
            txtPesoSaida.Size = new Size(145, 36);
            txtPesoSaida.TabIndex = 10;
            txtPesoSaida.KeyPress += txtPesoSaida_KeyPress;
            // 
            // txtPesoEntrada
            // 
            txtPesoEntrada.Location = new Point(689, 66);
            txtPesoEntrada.Name = "txtPesoEntrada";
            txtPesoEntrada.Size = new Size(145, 36);
            txtPesoEntrada.TabIndex = 9;
            txtPesoEntrada.KeyPress += txtPesoEntrada_KeyPress;
            // 
            // lblPesoSaida
            // 
            lblPesoSaida.AutoSize = true;
            lblPesoSaida.Location = new Point(850, 69);
            lblPesoSaida.Name = "lblPesoSaida";
            lblPesoSaida.Size = new Size(121, 30);
            lblPesoSaida.TabIndex = 8;
            lblPesoSaida.Text = "Peso Saída:";
            // 
            // lblPesoEntrada
            // 
            lblPesoEntrada.AutoSize = true;
            lblPesoEntrada.Location = new Point(541, 69);
            lblPesoEntrada.Name = "lblPesoEntrada";
            lblPesoEntrada.Size = new Size(142, 30);
            lblPesoEntrada.TabIndex = 7;
            lblPesoEntrada.Text = "Peso Entrada:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(142, 123);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(671, 36);
            txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(20, 126);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 30);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // dtsData
            // 
            dtsData.CustomFormat = "dd/MM/yyyy";
            dtsData.Format = DateTimePickerFormat.Short;
            dtsData.Location = new Point(213, 15);
            dtsData.Name = "dtsData";
            dtsData.Size = new Size(150, 36);
            dtsData.TabIndex = 3;
            dtsData.Value = new DateTime(2023, 11, 7, 20, 49, 57, 0);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(145, 18);
            lblData.Name = "lblData";
            lblData.Size = new Size(62, 30);
            lblData.TabIndex = 2;
            lblData.Text = "Data:";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(505, 14);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(631, 38);
            cmbFuncionario.TabIndex = 1;
            cmbFuncionario.Text = "Selecione o Funcionario";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(369, 18);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(130, 30);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionario:";
            // 
            // FormMovimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 621);
            Controls.Add(panFundo);
            Name = "FormMovimento";
            Text = "FormMovimento";
            Load += FormMovimento_Load;
            panFundo.ResumeLayout(false);
            panGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgMovimento).EndInit();
            panBotoes.ResumeLayout(false);
            panCadastro.ResumeLayout(false);
            panCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastro;
        private TextBox txtPesoEntrada;
        private Label lblPesoSaida;
        private Label lblPesoEntrada;
        private TextBox txtMovimento;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private DateTimePicker dtsData;
        private Label lblData;
        private ComboBox cmbFuncionario;
        private Label lblFuncionario;
        private Button btnSalvar;
        private TextBox txtPesoSaida;
        private DataGridView dtgMovimento;
        private Panel panBotoes;
        private Button btnRelatorio;
        private Button btnVoltar;
        private ComboBox cmbProcesso;
        private Label lblProcesso;
        private TextBox txtId;
        private Label lblId;
        private Button btnLimpar;
        private Panel panGrid;
    }
}