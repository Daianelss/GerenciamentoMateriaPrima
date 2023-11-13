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
            lblTipoMovimento = new Label();
            cmbTipoMovimento = new ComboBox();
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
            panGridGerenciamento = new Panel();
            dtgGerenciamento = new DataGridView();
            panBotoes = new Panel();
            btnRelatorio = new Button();
            btnAtualizar = new Button();
            btnVoltar = new Button();
            panCadastro.SuspendLayout();
            panGridGerenciamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgGerenciamento).BeginInit();
            panBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panCadastro
            // 
            panCadastro.Controls.Add(lblTipoMovimento);
            panCadastro.Controls.Add(cmbTipoMovimento);
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
            // lblTipoMovimento
            // 
            lblTipoMovimento.AutoSize = true;
            lblTipoMovimento.Location = new Point(607, 35);
            lblTipoMovimento.Name = "lblTipoMovimento";
            lblTipoMovimento.Size = new Size(179, 30);
            lblTipoMovimento.TabIndex = 13;
            lblTipoMovimento.Text = "Tipo Movimento:";
            // 
            // cmbTipoMovimento
            // 
            cmbTipoMovimento.FormattingEnabled = true;
            cmbTipoMovimento.Location = new Point(787, 31);
            cmbTipoMovimento.Name = "cmbTipoMovimento";
            cmbTipoMovimento.Size = new Size(350, 38);
            cmbTipoMovimento.TabIndex = 12;
            cmbTipoMovimento.Text = "Selecione";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1053, 136);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 41);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
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
            txtDescricao.Location = new Point(158, 138);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(886, 36);
            txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(41, 141);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 30);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // dtsData
            // 
            dtsData.CustomFormat = "";
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
            // panGridGerenciamento
            // 
            panGridGerenciamento.Controls.Add(dtgGerenciamento);
            panGridGerenciamento.Dock = DockStyle.Fill;
            panGridGerenciamento.Location = new Point(0, 195);
            panGridGerenciamento.Name = "panGridGerenciamento";
            panGridGerenciamento.Size = new Size(1168, 423);
            panGridGerenciamento.TabIndex = 1;
            // 
            // dtgGerenciamento
            // 
            dtgGerenciamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGerenciamento.Dock = DockStyle.Fill;
            dtgGerenciamento.Location = new Point(0, 0);
            dtgGerenciamento.Name = "dtgGerenciamento";
            dtgGerenciamento.RowTemplate.Height = 25;
            dtgGerenciamento.Size = new Size(1168, 423);
            dtgGerenciamento.TabIndex = 0;
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
            // FormGerenciamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panBotoes);
            Controls.Add(panGridGerenciamento);
            Controls.Add(panCadastro);
            Name = "FormGerenciamento";
            Text = "FormGerenciamento";
            panCadastro.ResumeLayout(false);
            panCadastro.PerformLayout();
            panGridGerenciamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgGerenciamento).EndInit();
            panBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastro;
        private Panel panGridGerenciamento;
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
        private DataGridView dtgGerenciamento;
        private Panel panBotoes;
        private Button btnRelatorio;
        private Button btnAtualizar;
        private Button btnVoltar;
        private ComboBox cmbTipoMovimento;
        private Label lblTipoMovimento;
    }
}