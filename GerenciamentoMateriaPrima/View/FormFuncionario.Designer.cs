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
            btnAtivarInativar = new Button();
            btnPesquisar = new Button();
            btnSalvar = new Button();
            TxtNomeFuncionario = new TextBox();
            lblNome = new Label();
            dtgFuncionario = new DataGridView();
            btnVoltar = new Button();
            panBotoes = new Panel();
            btnAtualizar = new Button();
            panFuncionario = new Panel();
            panCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionario).BeginInit();
            panBotoes.SuspendLayout();
            panFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // panCadastroFuncionario
            // 
            panCadastroFuncionario.Controls.Add(btnAtivarInativar);
            panCadastroFuncionario.Controls.Add(btnPesquisar);
            panCadastroFuncionario.Controls.Add(btnSalvar);
            panCadastroFuncionario.Controls.Add(TxtNomeFuncionario);
            panCadastroFuncionario.Controls.Add(lblNome);
            panCadastroFuncionario.Dock = DockStyle.Top;
            panCadastroFuncionario.Location = new Point(0, 0);
            panCadastroFuncionario.Name = "panCadastroFuncionario";
            panCadastroFuncionario.Size = new Size(1168, 76);
            panCadastroFuncionario.TabIndex = 0;
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
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(988, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(157, 48);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(804, 19);
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
            // dtgFuncionario
            // 
            dtgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFuncionario.Location = new Point(365, 134);
            dtgFuncionario.Name = "dtgFuncionario";
            dtgFuncionario.RowTemplate.Height = 25;
            dtgFuncionario.Size = new Size(412, 289);
            dtgFuncionario.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1069, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // panBotoes
            // 
            panBotoes.Controls.Add(btnAtualizar);
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
            panFuncionario.Controls.Add(panCadastroFuncionario);
            panFuncionario.Controls.Add(panBotoes);
            panFuncionario.Controls.Add(dtgFuncionario);
            panFuncionario.Dock = DockStyle.Fill;
            panFuncionario.Location = new Point(0, 0);
            panFuncionario.Name = "panFuncionario";
            panFuncionario.Size = new Size(1168, 618);
            panFuncionario.TabIndex = 3;
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
    }
}