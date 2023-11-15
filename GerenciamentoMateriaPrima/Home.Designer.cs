namespace GerenciamentoMateriaPrima
{
    partial class formHome
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
            lblQuebraPolitriz = new Label();
            lblQuebraPeroxido = new Label();
            lblPolitriz = new Label();
            lblPeroxido = new Label();
            lblQuebraBanca = new Label();
            lblBanca = new Label();
            lblQuebraFuncicao = new Label();
            lblFundicao = new Label();
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
            panResumo.Controls.Add(lblQuebraPolitriz);
            panResumo.Controls.Add(lblQuebraPeroxido);
            panResumo.Controls.Add(lblPolitriz);
            panResumo.Controls.Add(lblPeroxido);
            panResumo.Controls.Add(lblQuebraBanca);
            panResumo.Controls.Add(lblBanca);
            panResumo.Controls.Add(lblQuebraFuncicao);
            panResumo.Controls.Add(lblFundicao);
            panResumo.Dock = DockStyle.Right;
            panResumo.Location = new Point(734, 0);
            panResumo.Name = "panResumo";
            panResumo.Size = new Size(450, 618);
            panResumo.TabIndex = 0;
            // 
            // lblQuebraPolitriz
            // 
            lblQuebraPolitriz.AutoSize = true;
            lblQuebraPolitriz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuebraPolitriz.Location = new Point(274, 252);
            lblQuebraPolitriz.Name = "lblQuebraPolitriz";
            lblQuebraPolitriz.Size = new Size(40, 32);
            lblQuebraPolitriz.TabIndex = 7;
            lblQuebraPolitriz.Text = "15";
            // 
            // lblQuebraPeroxido
            // 
            lblQuebraPeroxido.AutoSize = true;
            lblQuebraPeroxido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuebraPeroxido.Location = new Point(157, 206);
            lblQuebraPeroxido.Name = "lblQuebraPeroxido";
            lblQuebraPeroxido.Size = new Size(53, 32);
            lblQuebraPeroxido.TabIndex = 6;
            lblQuebraPeroxido.Text = "489";
            // 
            // lblPolitriz
            // 
            lblPolitriz.AutoSize = true;
            lblPolitriz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPolitriz.Location = new Point(17, 252);
            lblPolitriz.Name = "lblPolitriz";
            lblPolitriz.Size = new Size(251, 32);
            lblPolitriz.TabIndex = 5;
            lblPolitriz.Text = "Material não utilizado:";
            // 
            // lblPeroxido
            // 
            lblPeroxido.AutoSize = true;
            lblPeroxido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeroxido.Location = new Point(17, 206);
            lblPeroxido.Name = "lblPeroxido";
            lblPeroxido.Size = new Size(134, 32);
            lblPeroxido.TabIndex = 4;
            lblPeroxido.Text = "Saida Total:";
            // 
            // lblQuebraBanca
            // 
            lblQuebraBanca.AutoSize = true;
            lblQuebraBanca.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuebraBanca.Location = new Point(179, 160);
            lblQuebraBanca.Name = "lblQuebraBanca";
            lblQuebraBanca.Size = new Size(53, 32);
            lblQuebraBanca.TabIndex = 3;
            lblQuebraBanca.Text = "500";
            // 
            // lblBanca
            // 
            lblBanca.AutoSize = true;
            lblBanca.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanca.Location = new Point(17, 160);
            lblBanca.Name = "lblBanca";
            lblBanca.Size = new Size(157, 32);
            lblBanca.TabIndex = 2;
            lblBanca.Text = "Entrada Total:";
            // 
            // lblQuebraFuncicao
            // 
            lblQuebraFuncicao.AutoSize = true;
            lblQuebraFuncicao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuebraFuncicao.Location = new Point(179, 114);
            lblQuebraFuncicao.Name = "lblQuebraFuncicao";
            lblQuebraFuncicao.Size = new Size(58, 32);
            lblQuebraFuncicao.TabIndex = 1;
            lblQuebraFuncicao.Text = "25.0";
            // 
            // lblFundicao
            // 
            lblFundicao.AutoSize = true;
            lblFundicao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFundicao.Location = new Point(17, 114);
            lblFundicao.Name = "lblFundicao";
            lblFundicao.Size = new Size(156, 32);
            lblFundicao.TabIndex = 0;
            lblFundicao.Text = "Quebra Total:";
            // 
            // btnMovimentos
            // 
            btnMovimentos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMovimentos.Location = new Point(139, 65);
            btnMovimentos.Name = "btnMovimentos";
            btnMovimentos.Size = new Size(170, 66);
            btnMovimentos.TabIndex = 1;
            btnMovimentos.Text = "Entrada / Saída";
            btnMovimentos.UseVisualStyleBackColor = true;
            btnMovimentos.Click += btnMovimentos_Click;
            // 
            // panBotoes
            // 
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
            btnFuncionario.Location = new Point(471, 59);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(170, 66);
            btnFuncionario.TabIndex = 12;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnProcesso
            // 
            btnProcesso.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcesso.Location = new Point(246, 59);
            btnProcesso.Name = "btnProcesso";
            btnProcesso.Size = new Size(170, 66);
            btnProcesso.TabIndex = 7;
            btnProcesso.Text = "Processo";
            btnProcesso.UseVisualStyleBackColor = true;
            btnProcesso.Click += btnProcesso_Click;
            // 
            // btnMateriaPrima
            // 
            btnMateriaPrima.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMateriaPrima.Location = new Point(21, 59);
            btnMateriaPrima.Name = "btnMateriaPrima";
            btnMateriaPrima.Size = new Size(170, 66);
            btnMateriaPrima.TabIndex = 9;
            btnMateriaPrima.Text = "Matéria Prima";
            btnMateriaPrima.UseVisualStyleBackColor = true;
            btnMateriaPrima.Click += btnMateriaPrima_Click;
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
            gprGerenciamento.Text = "Gerencimento";
            // 
            // btnBanca
            // 
            btnBanca.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanca.Location = new Point(363, 65);
            btnBanca.Name = "btnBanca";
            btnBanca.Size = new Size(170, 66);
            btnBanca.TabIndex = 5;
            btnBanca.Text = "Banca";
            btnBanca.UseVisualStyleBackColor = true;
            btnBanca.Click += btnBanca_Click;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 618);
            Controls.Add(panBotoes);
            Controls.Add(panResumo);
            Name = "formHome";
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
        private Label lblBanca;
        private Label lblQuebraFuncicao;
        private Label lblFundicao;
        private Label lblQuebraBanca;
        private Label lblQuebraPolitriz;
        private Label lblQuebraPeroxido;
        private Label lblPolitriz;
        private Label lblPeroxido;
        private Button btnMovimentos;
        private Panel panBotoes;
        private Button btnMateriaPrima;
        private Button btnProcesso;
        private Button btnBanca;
        private Button btnFuncionario;
        private GroupBox grpCadastro;
        private GroupBox gprGerenciamento;
    }
}