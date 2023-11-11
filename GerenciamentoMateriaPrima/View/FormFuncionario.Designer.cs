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
            lblStatusFuncionario = new Label();
            lblIdFuncionario = new Label();
            btnLimpar = new Button();
            btnAtivarInativar = new Button();
            btnSalvar = new Button();
            TxtNomeFuncionario = new TextBox();
            lblNome = new Label();
            btnPesquisar = new Button();
            dtgFuncionario = new DataGridView();
            btnVoltar = new Button();
            panBotoes = new Panel();
            btnAtualizar = new Button();
            panFuncionario = new Panel();
            panListaFuncionario = new Panel();
            panCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionario).BeginInit();
            panBotoes.SuspendLayout();
            panFuncionario.SuspendLayout();
            panListaFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // panCadastroFuncionario
            // 
            panCadastroFuncionario.Controls.Add(lblStatusFuncionario);
            panCadastroFuncionario.Controls.Add(lblIdFuncionario);
            panCadastroFuncionario.Controls.Add(btnLimpar);
            panCadastroFuncionario.Controls.Add(btnAtivarInativar);
            panCadastroFuncionario.Controls.Add(btnSalvar);
            panCadastroFuncionario.Controls.Add(TxtNomeFuncionario);
            panCadastroFuncionario.Controls.Add(lblNome);
            panCadastroFuncionario.Dock = DockStyle.Top;
            panCadastroFuncionario.Location = new Point(0, 0);
            panCadastroFuncionario.Name = "panCadastroFuncionario";
            panCadastroFuncionario.Size = new Size(1168, 76);
            panCadastroFuncionario.TabIndex = 0;
            // 
            // lblStatusFuncionario
            // 
            lblStatusFuncionario.AutoSize = true;
            lblStatusFuncionario.Location = new Point(172, 6);
            lblStatusFuncionario.Name = "lblStatusFuncionario";
            lblStatusFuncionario.Size = new Size(115, 15);
            lblStatusFuncionario.TabIndex = 7;
            lblStatusFuncionario.Text = "lblStatusFuncionario";
            // 
            // lblIdFuncionario
            // 
            lblIdFuncionario.AutoSize = true;
            lblIdFuncionario.Location = new Point(27, 8);
            lblIdFuncionario.Name = "lblIdFuncionario";
            lblIdFuncionario.Size = new Size(93, 15);
            lblIdFuncionario.TabIndex = 6;
            lblIdFuncionario.Text = "lblIdFuncionario";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(1015, 32);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtivarInativar
            // 
            btnAtivarInativar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtivarInativar.Location = new Point(620, 19);
            btnAtivarInativar.Name = "btnAtivarInativar";
            btnAtivarInativar.Size = new Size(157, 48);
            btnAtivarInativar.TabIndex = 4;
            btnAtivarInativar.Text = "Ativar";
            btnAtivarInativar.UseVisualStyleBackColor = true;
            btnAtivarInativar.Click += btnAtivarInativar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(810, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 48);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TxtNomeFuncionario
            // 
            TxtNomeFuncionario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeFuncionario.Location = new Point(114, 25);
            TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            TxtNomeFuncionario.Size = new Size(489, 36);
            TxtNomeFuncionario.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(30, 28);
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
            dtgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFuncionario.Dock = DockStyle.Fill;
            dtgFuncionario.Location = new Point(20, 20);
            dtgFuncionario.Name = "dtgFuncionario";
            dtgFuncionario.RowTemplate.Height = 25;
            dtgFuncionario.Size = new Size(1128, 431);
            dtgFuncionario.TabIndex = 0;
            dtgFuncionario.CellDoubleClick += dtgFuncionario_CellDoubleClick;
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
            ((System.ComponentModel.ISupportInitialize)dtgFuncionario).EndInit();
            panBotoes.ResumeLayout(false);
            panFuncionario.ResumeLayout(false);
            panListaFuncionario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastroFuncionario;
        private Label lblNome;
        private TextBox TxtNomeFuncionario;
        private Button btnAtivarInativar;
        private Button btnPesquisar;
        private Button btnSalvar;
        private Button btnVoltar;
        private DataGridView dtgFuncionario;
        private Panel panBotoes;
        private Button btnAtualizar;
        private Panel panFuncionario;
        private Label lblStatusFuncionario;
        private Label lblIdFuncionario;
        private Button btnLimpar;
        private Panel panListaFuncionario;
    }
}