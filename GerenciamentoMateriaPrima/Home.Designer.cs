namespace GerenciamentoMateriaPrima
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panResumo = new Panel();
            lblMaterialNaoUtilizado = new Label();
            lblSaidaTotal = new Label();
            lblTitleMaterialNaoUtilizado = new Label();
            lblTitleSaidaTotal = new Label();
            lblEntradaTotal = new Label();
            lblTitleEntradaTotal = new Label();
            lblQuebraTotal = new Label();
            lbltotais = new Label();
            lblTitleQuebraTotal = new Label();
            btnMovimentos = new Button();
            panBotoes = new Panel();
            grpCadastro = new GroupBox();
            btnFuncionario = new Button();
            btnProcesso = new Button();
            btnMateriaPrima = new Button();
            gprGerenciamento = new GroupBox();
            btnBanca = new Button();
            panResumo.SuspendLayout();
            panBotoes.SuspendLayout();
            grpCadastro.SuspendLayout();
            gprGerenciamento.SuspendLayout();
            SuspendLayout();
            // 
            // panResumo
            // 
            panResumo.BorderStyle = BorderStyle.FixedSingle;
            panResumo.Controls.Add(lblMaterialNaoUtilizado);
            panResumo.Controls.Add(lblSaidaTotal);
            panResumo.Controls.Add(lblTitleMaterialNaoUtilizado);
            panResumo.Controls.Add(lblTitleSaidaTotal);
            panResumo.Controls.Add(lblEntradaTotal);
            panResumo.Controls.Add(lblTitleEntradaTotal);
            panResumo.Controls.Add(lblQuebraTotal);
            panResumo.Controls.Add(lbltotais);
            panResumo.Controls.Add(lblTitleQuebraTotal);
            panResumo.Dock = DockStyle.Right;
            panResumo.Location = new Point(734, 0);
            panResumo.Name = "panResumo";
            panResumo.Size = new Size(450, 618);
            panResumo.TabIndex = 0;
            // 
            // lblMaterialNaoUtilizado
            // 
            lblMaterialNaoUtilizado.BackColor = SystemColors.GradientInactiveCaption;
            lblMaterialNaoUtilizado.BorderStyle = BorderStyle.FixedSingle;
            lblMaterialNaoUtilizado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaterialNaoUtilizado.Location = new Point(256, 361);
            lblMaterialNaoUtilizado.Name = "lblMaterialNaoUtilizado";
            lblMaterialNaoUtilizado.Size = new Size(182, 35);
            lblMaterialNaoUtilizado.TabIndex = 7;
            lblMaterialNaoUtilizado.Text = "0,00";
            lblMaterialNaoUtilizado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSaidaTotal
            // 
            lblSaidaTotal.BackColor = SystemColors.GradientInactiveCaption;
            lblSaidaTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSaidaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaidaTotal.Location = new Point(256, 315);
            lblSaidaTotal.Name = "lblSaidaTotal";
            lblSaidaTotal.Size = new Size(182, 35);
            lblSaidaTotal.TabIndex = 6;
            lblSaidaTotal.Text = "0,00";
            lblSaidaTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitleMaterialNaoUtilizado
            // 
            lblTitleMaterialNaoUtilizado.AutoSize = true;
            lblTitleMaterialNaoUtilizado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMaterialNaoUtilizado.Location = new Point(6, 362);
            lblTitleMaterialNaoUtilizado.Name = "lblTitleMaterialNaoUtilizado";
            lblTitleMaterialNaoUtilizado.Size = new Size(251, 32);
            lblTitleMaterialNaoUtilizado.TabIndex = 5;
            lblTitleMaterialNaoUtilizado.Text = "Material não utilizado:";
            // 
            // lblTitleSaidaTotal
            // 
            lblTitleSaidaTotal.AutoSize = true;
            lblTitleSaidaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleSaidaTotal.Location = new Point(6, 316);
            lblTitleSaidaTotal.Name = "lblTitleSaidaTotal";
            lblTitleSaidaTotal.Size = new Size(134, 32);
            lblTitleSaidaTotal.TabIndex = 4;
            lblTitleSaidaTotal.Text = "Saída Total:";
            // 
            // lblEntradaTotal
            // 
            lblEntradaTotal.BackColor = SystemColors.GradientInactiveCaption;
            lblEntradaTotal.BorderStyle = BorderStyle.FixedSingle;
            lblEntradaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntradaTotal.Location = new Point(256, 269);
            lblEntradaTotal.Name = "lblEntradaTotal";
            lblEntradaTotal.Size = new Size(182, 35);
            lblEntradaTotal.TabIndex = 3;
            lblEntradaTotal.Text = "0,00";
            lblEntradaTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitleEntradaTotal
            // 
            lblTitleEntradaTotal.AutoSize = true;
            lblTitleEntradaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleEntradaTotal.Location = new Point(6, 270);
            lblTitleEntradaTotal.Name = "lblTitleEntradaTotal";
            lblTitleEntradaTotal.Size = new Size(157, 32);
            lblTitleEntradaTotal.TabIndex = 2;
            lblTitleEntradaTotal.Text = "Entrada Total:";
            // 
            // lblQuebraTotal
            // 
            lblQuebraTotal.BackColor = SystemColors.GradientInactiveCaption;
            lblQuebraTotal.BorderStyle = BorderStyle.FixedSingle;
            lblQuebraTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuebraTotal.Location = new Point(256, 223);
            lblQuebraTotal.Name = "lblQuebraTotal";
            lblQuebraTotal.Size = new Size(182, 35);
            lblQuebraTotal.TabIndex = 1;
            lblQuebraTotal.Text = "0,00";
            lblQuebraTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbltotais
            // 
            lbltotais.BackColor = SystemColors.WindowFrame;
            lbltotais.BorderStyle = BorderStyle.FixedSingle;
            lbltotais.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotais.ForeColor = Color.White;
            lbltotais.Location = new Point(10, 145);
            lbltotais.Name = "lbltotais";
            lbltotais.Size = new Size(429, 44);
            lbltotais.TabIndex = 0;
            lbltotais.Text = "Totais (gramas)";
            lbltotais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleQuebraTotal
            // 
            lblTitleQuebraTotal.AutoSize = true;
            lblTitleQuebraTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleQuebraTotal.Location = new Point(6, 224);
            lblTitleQuebraTotal.Name = "lblTitleQuebraTotal";
            lblTitleQuebraTotal.Size = new Size(156, 32);
            lblTitleQuebraTotal.TabIndex = 0;
            lblTitleQuebraTotal.Text = "Quebra Total:";
            // 
            // btnMovimentos
            // 
            btnMovimentos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMovimentos.Location = new Point(17, 68);
            btnMovimentos.Name = "btnMovimentos";
            btnMovimentos.Size = new Size(297, 66);
            btnMovimentos.TabIndex = 1;
            btnMovimentos.Text = "Entrada / Saída";
            btnMovimentos.UseVisualStyleBackColor = true;
            btnMovimentos.Click += btnAbrirForm_Click;
            // 
            // panBotoes
            // 
            panBotoes.BorderStyle = BorderStyle.FixedSingle;
            panBotoes.Controls.Add(grpCadastro);
            panBotoes.Controls.Add(gprGerenciamento);
            panBotoes.Dock = DockStyle.Fill;
            panBotoes.Location = new Point(0, 0);
            panBotoes.Name = "panBotoes";
            panBotoes.Size = new Size(734, 618);
            panBotoes.TabIndex = 1;
            // 
            // grpCadastro
            // 
            grpCadastro.Controls.Add(btnFuncionario);
            grpCadastro.Controls.Add(btnProcesso);
            grpCadastro.Controls.Add(btnMateriaPrima);
            grpCadastro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            grpCadastro.Location = new Point(33, 314);
            grpCadastro.Name = "grpCadastro";
            grpCadastro.Size = new Size(653, 161);
            grpCadastro.TabIndex = 14;
            grpCadastro.TabStop = false;
            grpCadastro.Text = "Cadastro";
            // 
            // btnFuncionario
            // 
            btnFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionario.Location = new Point(467, 59);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(170, 66);
            btnFuncionario.TabIndex = 12;
            btnFuncionario.Text = "Funcionário";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnAbrirForm_Click;
            // 
            // btnProcesso
            // 
            btnProcesso.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcesso.Location = new Point(242, 59);
            btnProcesso.Name = "btnProcesso";
            btnProcesso.Size = new Size(170, 66);
            btnProcesso.TabIndex = 7;
            btnProcesso.Text = "Processo";
            btnProcesso.UseVisualStyleBackColor = true;
            btnProcesso.Click += btnAbrirForm_Click;
            // 
            // btnMateriaPrima
            // 
            btnMateriaPrima.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMateriaPrima.Location = new Point(17, 59);
            btnMateriaPrima.Name = "btnMateriaPrima";
            btnMateriaPrima.Size = new Size(170, 66);
            btnMateriaPrima.TabIndex = 9;
            btnMateriaPrima.Text = "Matéria Prima";
            btnMateriaPrima.UseVisualStyleBackColor = true;
            btnMateriaPrima.Click += btnAbrirForm_Click;
            // 
            // gprGerenciamento
            // 
            gprGerenciamento.Controls.Add(btnBanca);
            gprGerenciamento.Controls.Add(btnMovimentos);
            gprGerenciamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            gprGerenciamento.Location = new Point(33, 55);
            gprGerenciamento.Margin = new Padding(3, 3, 3, 50);
            gprGerenciamento.Name = "gprGerenciamento";
            gprGerenciamento.Size = new Size(653, 204);
            gprGerenciamento.TabIndex = 13;
            gprGerenciamento.TabStop = false;
            gprGerenciamento.Text = "Gerenciamento";
            // 
            // btnBanca
            // 
            btnBanca.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanca.Location = new Point(340, 68);
            btnBanca.Name = "btnBanca";
            btnBanca.Size = new Size(297, 66);
            btnBanca.TabIndex = 5;
            btnBanca.Text = "Banca";
            btnBanca.UseVisualStyleBackColor = true;
            btnBanca.Click += btnAbrirForm_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 618);
            Controls.Add(panBotoes);
            Controls.Add(panResumo);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panResumo.ResumeLayout(false);
            panResumo.PerformLayout();
            panBotoes.ResumeLayout(false);
            grpCadastro.ResumeLayout(false);
            gprGerenciamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panResumo;
        private Label lblTitleEntradaTotal;
        private Label lblQuebraTotal;
        private Label lblTitleQuebraTotal;
        private Label lblEntradaTotal;
        private Label lblMaterialNaoUtilizado;
        private Label lblSaidaTotal;
        private Label lblTitleMaterialNaoUtilizado;
        private Label lblTitleSaidaTotal;
        private Button btnMovimentos;
        private Panel panBotoes;
        private Button btnMateriaPrima;
        private Button btnProcesso;
        private Button btnBanca;
        private Button btnFuncionario;
        private GroupBox grpCadastro;
        private GroupBox gprGerenciamento;
        private Label lbltotais;
    }
}