namespace GerenciamentoMateriaPrima.View
{
    partial class FormTipoProcesso
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
            panLista = new Panel();
            dtgTipoProcesso = new DataGridView();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            gpbStatus = new GroupBox();
            chkStatus = new CheckBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            panBotoes = new Panel();
            btnPesquisar = new Button();
            btnVoltar = new Button();
            txtNome = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            panTipoProcesso = new Panel();
            panCadastro = new Panel();
            panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTipoProcesso).BeginInit();
            gpbStatus.SuspendLayout();
            panBotoes.SuspendLayout();
            panTipoProcesso.SuspendLayout();
            panCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panLista
            // 
            panLista.Controls.Add(dtgTipoProcesso);
            panLista.Dock = DockStyle.Fill;
            panLista.Location = new Point(0, 133);
            panLista.Name = "panLista";
            panLista.Padding = new Padding(20);
            panLista.Size = new Size(1168, 414);
            panLista.TabIndex = 3;
            // 
            // dtgTipoProcesso
            // 
            dtgTipoProcesso.AllowUserToAddRows = false;
            dtgTipoProcesso.AllowUserToDeleteRows = false;
            dtgTipoProcesso.AllowUserToResizeColumns = false;
            dtgTipoProcesso.AllowUserToResizeRows = false;
            dtgTipoProcesso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTipoProcesso.Dock = DockStyle.Fill;
            dtgTipoProcesso.Location = new Point(20, 20);
            dtgTipoProcesso.MultiSelect = false;
            dtgTipoProcesso.Name = "dtgTipoProcesso";
            dtgTipoProcesso.ReadOnly = true;
            dtgTipoProcesso.RowTemplate.Height = 25;
            dtgTipoProcesso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTipoProcesso.Size = new Size(1128, 374);
            dtgTipoProcesso.TabIndex = 0;
            dtgTipoProcesso.CellClick += dtgTipoProcesso_CellClick;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(126, 70);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1016, 36);
            txtDescricao.TabIndex = 11;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.Location = new Point(9, 73);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 30);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descrição:";
            // 
            // gpbStatus
            // 
            gpbStatus.Controls.Add(chkStatus);
            gpbStatus.Location = new Point(641, 9);
            gpbStatus.Name = "gpbStatus";
            gpbStatus.Size = new Size(94, 48);
            gpbStatus.TabIndex = 9;
            gpbStatus.TabStop = false;
            gpbStatus.Text = "Status";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(20, 20);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(54, 19);
            chkStatus.TabIndex = 8;
            chkStatus.Text = "Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(972, 9);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(157, 48);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(803, 9);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 48);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(52, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(84, 36);
            txtId.TabIndex = 1;
            // 
            // panBotoes
            // 
            panBotoes.Controls.Add(btnPesquisar);
            panBotoes.Controls.Add(btnVoltar);
            panBotoes.Dock = DockStyle.Bottom;
            panBotoes.Location = new Point(0, 547);
            panBotoes.Name = "panBotoes";
            panBotoes.Size = new Size(1168, 71);
            panBotoes.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(825, 11);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(157, 48);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(996, 11);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(157, 48);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(256, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 36);
            txtNome.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(9, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 30);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(161, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(78, 30);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // panTipoProcesso
            // 
            panTipoProcesso.Controls.Add(panLista);
            panTipoProcesso.Controls.Add(panCadastro);
            panTipoProcesso.Controls.Add(panBotoes);
            panTipoProcesso.Dock = DockStyle.Fill;
            panTipoProcesso.Location = new Point(0, 0);
            panTipoProcesso.Name = "panTipoProcesso";
            panTipoProcesso.Size = new Size(1168, 618);
            panTipoProcesso.TabIndex = 5;
            // 
            // panCadastro
            // 
            panCadastro.Controls.Add(txtDescricao);
            panCadastro.Controls.Add(lblDescricao);
            panCadastro.Controls.Add(gpbStatus);
            panCadastro.Controls.Add(btnLimpar);
            panCadastro.Controls.Add(btnSalvar);
            panCadastro.Controls.Add(txtId);
            panCadastro.Controls.Add(txtNome);
            panCadastro.Controls.Add(lblId);
            panCadastro.Controls.Add(lblNome);
            panCadastro.Dock = DockStyle.Top;
            panCadastro.Location = new Point(0, 0);
            panCadastro.Name = "panCadastro";
            panCadastro.Size = new Size(1168, 133);
            panCadastro.TabIndex = 0;
            // 
            // FormTipoProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panTipoProcesso);
            Name = "FormTipoProcesso";
            Text = "Processo";
            Load += FormTipoProcesso_Load;
            panLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgTipoProcesso).EndInit();
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            panBotoes.ResumeLayout(false);
            panTipoProcesso.ResumeLayout(false);
            panCadastro.ResumeLayout(false);
            panCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panLista;
        private DataGridView dtgTipoProcesso;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private GroupBox gpbStatus;
        private CheckBox chkStatus;
        private Button btnLimpar;
        private Button btnSalvar;
        private TextBox txtId;
        private Panel panBotoes;
        private Button btnPesquisar;
        private Button btnVoltar;
        private TextBox txtNome;
        private Label lblId;
        private Label lblNome;
        private Panel panTipoProcesso;
        private Panel panCadastro;
    }
}