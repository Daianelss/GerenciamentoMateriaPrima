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
            panGridMovimento = new Panel();
            dtgMovimento = new DataGridView();
            panBotoes = new Panel();
            btnRelatorio = new Button();
            btnAtualizar = new Button();
            btnVoltar = new Button();
            panCadastro.SuspendLayout();
            panGridMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMovimento).BeginInit();
            panBotoes.SuspendLayout();
            SuspendLayout();
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
            panCadastro.Size = new Size(1168, 195);
            panCadastro.TabIndex = 0;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(883, 136);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(103, 41);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(409, 80);
            txtId.Name = "txtId";
            txtId.Size = new Size(84, 36);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(366, 83);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 30);
            lblId.TabIndex = 3;
            lblId.Text = "Id:";
            // 
            // lblProcesso
            // 
            lblProcesso.AutoSize = true;
            lblProcesso.Location = new Point(607, 35);
            lblProcesso.Name = "lblProcesso";
            lblProcesso.Size = new Size(104, 30);
            lblProcesso.TabIndex = 13;
            lblProcesso.Text = "Processo:";
            // 
            // cmbProcesso
            // 
            cmbProcesso.FormattingEnabled = true;
            cmbProcesso.Location = new Point(787, 31);
            cmbProcesso.Name = "cmbProcesso";
            cmbProcesso.Size = new Size(350, 38);
            cmbProcesso.TabIndex = 12;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1045, 136);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 41);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPesoSaida
            // 
            txtPesoSaida.Location = new Point(992, 80);
            txtPesoSaida.Name = "txtPesoSaida";
            txtPesoSaida.Size = new Size(145, 36);
            txtPesoSaida.TabIndex = 10;
            // 
            // txtPesoEntrada
            // 
            txtPesoEntrada.Location = new Point(704, 80);
            txtPesoEntrada.Name = "txtPesoEntrada";
            txtPesoEntrada.Size = new Size(145, 36);
            txtPesoEntrada.TabIndex = 9;
            // 
            // lblPesoSaida
            // 
            lblPesoSaida.AutoSize = true;
            lblPesoSaida.Location = new Point(865, 83);
            lblPesoSaida.Name = "lblPesoSaida";
            lblPesoSaida.Size = new Size(121, 30);
            lblPesoSaida.TabIndex = 8;
            lblPesoSaida.Text = "Peso Saída:";
            // 
            // lblPesoEntrada
            // 
            lblPesoEntrada.AutoSize = true;
            lblPesoEntrada.Location = new Point(556, 83);
            lblPesoEntrada.Name = "lblPesoEntrada";
            lblPesoEntrada.Size = new Size(142, 30);
            lblPesoEntrada.TabIndex = 7;
            lblPesoEntrada.Text = "Peso Entrada:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(139, 141);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(710, 36);
            txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(22, 144);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 30);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // dtsData
            // 
            dtsData.CustomFormat = "dd/MM/yyyy";
            dtsData.Format = DateTimePickerFormat.Short;
            dtsData.Location = new Point(109, 80);
            dtsData.Name = "dtsData";
            dtsData.Size = new Size(212, 36);
            dtsData.TabIndex = 3;
            dtsData.Value = new DateTime(2023, 11, 7, 20, 49, 57, 0);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(41, 83);
            lblData.Name = "lblData";
            lblData.Size = new Size(62, 30);
            lblData.TabIndex = 2;
            lblData.Text = "Data:";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(172, 31);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(350, 38);
            cmbFuncionario.TabIndex = 1;
            cmbFuncionario.Text = "Selecione o Funcionario";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(41, 35);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(125, 30);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionario";
            // 
            // panGridMovimento
            // 
            panGridMovimento.Controls.Add(dtgMovimento);
            panGridMovimento.Dock = DockStyle.Fill;
            panGridMovimento.Location = new Point(0, 195);
            panGridMovimento.Name = "panGridMovimento";
            panGridMovimento.Padding = new Padding(20);
            panGridMovimento.Size = new Size(1168, 423);
            panGridMovimento.TabIndex = 1;
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
            dtgMovimento.Size = new Size(1128, 383);
            dtgMovimento.TabIndex = 0;
            dtgMovimento.CellClick += dtgMovimento_CellClick;
            // 
            // panBotoes
            // 
            panBotoes.Controls.Add(btnRelatorio);
            panBotoes.Controls.Add(btnAtualizar);
            panBotoes.Controls.Add(btnVoltar);
            panBotoes.Dock = DockStyle.Bottom;
            panBotoes.Location = new Point(0, 558);
            panBotoes.Name = "panBotoes";
            panBotoes.Size = new Size(1168, 60);
            panBotoes.TabIndex = 2;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(1062, 18);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(75, 23);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(950, 18);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(842, 18);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FormMovimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panBotoes);
            Controls.Add(panGridMovimento);
            Controls.Add(panCadastro);
            Name = "FormMovimento";
            Text = "FormMovimento";
            Load += FormMovimento_Load;
            panCadastro.ResumeLayout(false);
            panCadastro.PerformLayout();
            panGridMovimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgMovimento).EndInit();
            panBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastro;
        private Panel panGridMovimento;
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
        private Button btnAtualizar;
        private Button btnVoltar;
        private ComboBox cmbProcesso;
        private Label lblProcesso;
        private TextBox txtId;
        private Label lblId;
        private Button btnLimpar;
    }
}