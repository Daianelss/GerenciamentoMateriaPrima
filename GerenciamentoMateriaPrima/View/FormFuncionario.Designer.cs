namespace GerenciamentoMateriaPrima.View
{
    partial class FormFuncionario
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
            panCadastroFuncionario = new Panel();
            gpbStatus = new GroupBox();
            chkStatus = new CheckBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            txtIdFuncionario = new TextBox();
            txtNomeFuncionario = new TextBox();
            lblIdFuncionario = new Label();
            lblNome = new Label();
            btnPesquisar = new Button();
            dtgFuncionario = new DataGridView();
            btnVoltar = new Button();
            panBotoes = new Panel();
            btnAtualizar = new Button();
            panFuncionario = new Panel();
            panListaFuncionario = new Panel();
            panCadastroFuncionario.SuspendLayout();
            gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionario).BeginInit();
            panBotoes.SuspendLayout();
            panFuncionario.SuspendLayout();
            panListaFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // panCadastroFuncionario
            // 
            panCadastroFuncionario.Controls.Add(gpbStatus);
            panCadastroFuncionario.Controls.Add(btnLimpar);
            panCadastroFuncionario.Controls.Add(btnSalvar);
            panCadastroFuncionario.Controls.Add(txtIdFuncionario);
            panCadastroFuncionario.Controls.Add(txtNomeFuncionario);
            panCadastroFuncionario.Controls.Add(lblIdFuncionario);
            panCadastroFuncionario.Controls.Add(lblNome);
            panCadastroFuncionario.Dock = DockStyle.Top;
            panCadastroFuncionario.Location = new Point(0, 0);
            panCadastroFuncionario.Name = "panCadastroFuncionario";
            panCadastroFuncionario.Size = new Size(1168, 76);
            panCadastroFuncionario.TabIndex = 0;
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
            btnLimpar.Location = new Point(1067, 32);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(904, 10);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 48);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtIdFuncionario
            // 
            txtIdFuncionario.Enabled = false;
            txtIdFuncionario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdFuncionario.Location = new Point(52, 18);
            txtIdFuncionario.Name = "txtIdFuncionario";
            txtIdFuncionario.Size = new Size(84, 36);
            txtIdFuncionario.TabIndex = 1;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeFuncionario.Location = new Point(256, 21);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(377, 36);
            txtNomeFuncionario.TabIndex = 1;
            // 
            // lblIdFuncionario
            // 
            lblIdFuncionario.AutoSize = true;
            lblIdFuncionario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdFuncionario.Location = new Point(9, 21);
            lblIdFuncionario.Name = "lblIdFuncionario";
            lblIdFuncionario.Size = new Size(37, 30);
            lblIdFuncionario.TabIndex = 0;
            lblIdFuncionario.Text = "Id:";
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
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(787, 11);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(157, 48);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dtgFuncionario
            // 
            dtgFuncionario.AllowUserToAddRows = false;
            dtgFuncionario.AllowUserToDeleteRows = false;
            dtgFuncionario.AllowUserToResizeColumns = false;
            dtgFuncionario.AllowUserToResizeRows = false;
            dtgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFuncionario.Dock = DockStyle.Fill;
            dtgFuncionario.Location = new Point(20, 20);
            dtgFuncionario.MultiSelect = false;
            dtgFuncionario.Name = "dtgFuncionario";
            dtgFuncionario.ReadOnly = true;
            dtgFuncionario.RowTemplate.Height = 25;
            dtgFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFuncionario.Size = new Size(1128, 431);
            dtgFuncionario.TabIndex = 0;
            dtgFuncionario.CellClick += dtgFuncionario_CellClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1069, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panBotoes
            // 
            panBotoes.Controls.Add(btnAtualizar);
            panBotoes.Controls.Add(btnPesquisar);
            panBotoes.Controls.Add(btnVoltar);
            panBotoes.Dock = DockStyle.Bottom;
            panBotoes.Location = new Point(0, 547);
            panBotoes.Name = "panBotoes";
            panBotoes.Size = new Size(1168, 71);
            panBotoes.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(972, 16);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // panFuncionario
            // 
            panFuncionario.Controls.Add(panListaFuncionario);
            panFuncionario.Controls.Add(panCadastroFuncionario);
            panFuncionario.Controls.Add(panBotoes);
            panFuncionario.Dock = DockStyle.Fill;
            panFuncionario.Location = new Point(0, 0);
            panFuncionario.Name = "panFuncionario";
            panFuncionario.Size = new Size(1168, 618);
            panFuncionario.TabIndex = 3;
            // 
            // panListaFuncionario
            // 
            panListaFuncionario.Controls.Add(dtgFuncionario);
            panListaFuncionario.Dock = DockStyle.Fill;
            panListaFuncionario.Location = new Point(0, 76);
            panListaFuncionario.Name = "panListaFuncionario";
            panListaFuncionario.Padding = new Padding(20);
            panListaFuncionario.Size = new Size(1168, 471);
            panListaFuncionario.TabIndex = 3;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panFuncionario);
            Name = "FormFuncionario";
            Text = "Funcionario";
            Load += FormFuncionario_Load;
            panCadastroFuncionario.ResumeLayout(false);
            panCadastroFuncionario.PerformLayout();
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionario).EndInit();
            panBotoes.ResumeLayout(false);
            panFuncionario.ResumeLayout(false);
            panListaFuncionario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastroFuncionario;
        private Label lblNome;
        private TextBox txtNomeFuncionario;
        private Button btnPesquisar;
        private Button btnSalvar;
        private Button btnVoltar;
        private DataGridView dtgFuncionario;
        private Panel panBotoes;
        private Button btnAtualizar;
        private Panel panFuncionario;
        private Button btnLimpar;
        private Panel panListaFuncionario;
        private CheckBox chkStatus;
        private TextBox txtIdFuncionario;
        private Label lblIdFuncionario;
        private GroupBox gpbStatus;
    }
}