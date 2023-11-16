namespace GerenciamentoMateriaPrima.View
{
    partial class FormMovimentoMateriaPrima
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
            panFundo = new Panel();
            panListaMovimento = new Panel();
            dtgListaMovimento = new DataGridView();
            panOpcoes = new Panel();
            btnVoltar = new Button();
            btnRelatorio = new Button();
            panCadastroMovimento = new Panel();
            dtData = new DateTimePicker();
            lblTipoMateriaPrima = new Label();
            cmbTipoMateriaPrima = new ComboBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            txtDescricao = new TextBox();
            txtPeso = new TextBox();
            txtId = new TextBox();
            gpbTipoMovimento = new GroupBox();
            rdbSaida = new RadioButton();
            rdbEntrada = new RadioButton();
            lblDescricao = new Label();
            lblPeso = new Label();
            lblData = new Label();
            lblId = new Label();
            panFundo.SuspendLayout();
            panListaMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaMovimento).BeginInit();
            panOpcoes.SuspendLayout();
            panCadastroMovimento.SuspendLayout();
            gpbTipoMovimento.SuspendLayout();
            SuspendLayout();
            // 
            // panFundo
            // 
            panFundo.Controls.Add(panListaMovimento);
            panFundo.Controls.Add(panOpcoes);
            panFundo.Controls.Add(panCadastroMovimento);
            panFundo.Dock = DockStyle.Fill;
            panFundo.Location = new Point(0, 0);
            panFundo.Name = "panFundo";
            panFundo.Size = new Size(1184, 621);
            panFundo.TabIndex = 0;
            // 
            // panListaMovimento
            // 
            panListaMovimento.Controls.Add(dtgListaMovimento);
            panListaMovimento.Dock = DockStyle.Fill;
            panListaMovimento.Location = new Point(0, 169);
            panListaMovimento.Name = "panListaMovimento";
            panListaMovimento.Padding = new Padding(20);
            panListaMovimento.Size = new Size(1184, 387);
            panListaMovimento.TabIndex = 2;
            // 
            // dtgListaMovimento
            // 
            dtgListaMovimento.AllowUserToAddRows = false;
            dtgListaMovimento.AllowUserToDeleteRows = false;
            dtgListaMovimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaMovimento.Dock = DockStyle.Fill;
            dtgListaMovimento.Location = new Point(20, 20);
            dtgListaMovimento.MultiSelect = false;
            dtgListaMovimento.Name = "dtgListaMovimento";
            dtgListaMovimento.ReadOnly = true;
            dtgListaMovimento.RowTemplate.Height = 25;
            dtgListaMovimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListaMovimento.Size = new Size(1144, 347);
            dtgListaMovimento.TabIndex = 0;
            dtgListaMovimento.CellClick += dtgListaMovimento_CellClick;
            // 
            // panOpcoes
            // 
            panOpcoes.Controls.Add(btnVoltar);
            panOpcoes.Controls.Add(btnRelatorio);
            panOpcoes.Dock = DockStyle.Bottom;
            panOpcoes.Location = new Point(0, 556);
            panOpcoes.Name = "panOpcoes";
            panOpcoes.Size = new Size(1184, 65);
            panOpcoes.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(1004, 6);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(160, 50);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorio.Location = new Point(837, 6);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(160, 50);
            btnRelatorio.TabIndex = 0;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // panCadastroMovimento
            // 
            panCadastroMovimento.Controls.Add(dtData);
            panCadastroMovimento.Controls.Add(lblTipoMateriaPrima);
            panCadastroMovimento.Controls.Add(cmbTipoMateriaPrima);
            panCadastroMovimento.Controls.Add(btnLimpar);
            panCadastroMovimento.Controls.Add(btnSalvar);
            panCadastroMovimento.Controls.Add(txtDescricao);
            panCadastroMovimento.Controls.Add(txtPeso);
            panCadastroMovimento.Controls.Add(txtId);
            panCadastroMovimento.Controls.Add(gpbTipoMovimento);
            panCadastroMovimento.Controls.Add(lblDescricao);
            panCadastroMovimento.Controls.Add(lblPeso);
            panCadastroMovimento.Controls.Add(lblData);
            panCadastroMovimento.Controls.Add(lblId);
            panCadastroMovimento.Dock = DockStyle.Top;
            panCadastroMovimento.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panCadastroMovimento.Location = new Point(0, 0);
            panCadastroMovimento.Name = "panCadastroMovimento";
            panCadastroMovimento.Size = new Size(1184, 169);
            panCadastroMovimento.TabIndex = 0;
            // 
            // dtData
            // 
            dtData.CustomFormat = "dd/MM/yyyy";
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(402, 30);
            dtData.Name = "dtData";
            dtData.Size = new Size(164, 39);
            dtData.TabIndex = 2;
            dtData.Value = new DateTime(2023, 11, 12, 16, 5, 34, 0);
            // 
            // lblTipoMateriaPrima
            // 
            lblTipoMateriaPrima.AutoSize = true;
            lblTipoMateriaPrima.Location = new Point(20, 83);
            lblTipoMateriaPrima.Name = "lblTipoMateriaPrima";
            lblTipoMateriaPrima.Size = new Size(155, 32);
            lblTipoMateriaPrima.TabIndex = 12;
            lblTipoMateriaPrima.Text = "MateriaPrima";
            // 
            // cmbTipoMateriaPrima
            // 
            cmbTipoMateriaPrima.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMateriaPrima.FormattingEnabled = true;
            cmbTipoMateriaPrima.Location = new Point(178, 79);
            cmbTipoMateriaPrima.Name = "cmbTipoMateriaPrima";
            cmbTipoMateriaPrima.Size = new Size(820, 40);
            cmbTipoMateriaPrima.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(1004, 67);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 50);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1004, 7);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 50);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(144, 125);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1020, 39);
            txtDescricao.TabIndex = 6;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(221, 30);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 39);
            txtPeso.TabIndex = 1;
            txtPeso.KeyPress += ValidarNumero;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(56, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(85, 39);
            txtId.TabIndex = 5;
            // 
            // gpbTipoMovimento
            // 
            gpbTipoMovimento.Controls.Add(rdbSaida);
            gpbTipoMovimento.Controls.Add(rdbEntrada);
            gpbTipoMovimento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gpbTipoMovimento.Location = new Point(572, 7);
            gpbTipoMovimento.Name = "gpbTipoMovimento";
            gpbTipoMovimento.Size = new Size(207, 68);
            gpbTipoMovimento.TabIndex = 4;
            gpbTipoMovimento.TabStop = false;
            gpbTipoMovimento.Text = "Tipo Movimento";
            // 
            // rdbSaida
            // 
            rdbSaida.AutoSize = true;
            rdbSaida.Location = new Point(109, 30);
            rdbSaida.Name = "rdbSaida";
            rdbSaida.Size = new Size(78, 32);
            rdbSaida.TabIndex = 4;
            rdbSaida.TabStop = true;
            rdbSaida.Text = "Saida";
            rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            rdbEntrada.AutoSize = true;
            rdbEntrada.Location = new Point(6, 30);
            rdbEntrada.Name = "rdbEntrada";
            rdbEntrada.Size = new Size(97, 32);
            rdbEntrada.TabIndex = 3;
            rdbEntrada.TabStop = true;
            rdbEntrada.Text = "Entrada";
            rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(20, 128);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(121, 32);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(147, 33);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(68, 32);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(328, 33);
            lblData.Name = "lblData";
            lblData.Size = new Size(68, 32);
            lblData.TabIndex = 1;
            lblData.Text = "Data:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // FormMovimentoMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 621);
            Controls.Add(panFundo);
            Name = "FormMovimentoMateriaPrima";
            Text = "Entrada / Saída";
            Load += FormMovimentoMateriaPrima_Load;
            panFundo.ResumeLayout(false);
            panListaMovimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListaMovimento).EndInit();
            panOpcoes.ResumeLayout(false);
            panCadastroMovimento.ResumeLayout(false);
            panCadastroMovimento.PerformLayout();
            gpbTipoMovimento.ResumeLayout(false);
            gpbTipoMovimento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panFundo;
        private Panel panListaMovimento;
        private Panel panOpcoes;
        private Panel panCadastroMovimento;
        private Label lblData;
        private Label lblId;
        private GroupBox gpbTipoMovimento;
        private Label lblDescricao;
        private Label lblPeso;
        private RadioButton rdbSaida;
        private RadioButton rdbEntrada;
        private TextBox txtDescricao;
        private TextBox txtPeso;
        private TextBox txtId;
        private DataGridView dtgListaMovimento;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnRelatorio;
        private DateTimePicker dtData;
        private Button btnVoltar;
        private Label lblTipoMateriaPrima;
        private ComboBox cmbTipoMateriaPrima;
    }
}