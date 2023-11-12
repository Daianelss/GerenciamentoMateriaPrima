namespace GerenciamentoMateriaPrima.View
{
    partial class FormMateriaPrima
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
            PanFundo = new Panel();
            panListaMateriaPrima = new Panel();
            dtgTipoMateriaPrima = new DataGridView();
            panOpcoes = new Panel();
            panel1 = new Panel();
            btnSalvar = new Button();
            txtDescricaoTipoMateriaPrima = new TextBox();
            lblDescricaoTipoMateriaPrima = new Label();
            txtNomeTipoMateriaPrima = new TextBox();
            lblNomeTipoMateriaPrima = new Label();
            lblIdTipoMateriaPrima = new Label();
            PanFundo.SuspendLayout();
            panListaMateriaPrima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTipoMateriaPrima).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanFundo
            // 
            PanFundo.Controls.Add(panListaMateriaPrima);
            PanFundo.Controls.Add(panOpcoes);
            PanFundo.Controls.Add(panel1);
            PanFundo.Dock = DockStyle.Fill;
            PanFundo.Location = new Point(0, 0);
            PanFundo.Name = "PanFundo";
            PanFundo.Size = new Size(1168, 618);
            PanFundo.TabIndex = 0;
            // 
            // panListaMateriaPrima
            // 
            panListaMateriaPrima.Controls.Add(dtgTipoMateriaPrima);
            panListaMateriaPrima.Dock = DockStyle.Fill;
            panListaMateriaPrima.Location = new Point(0, 100);
            panListaMateriaPrima.Name = "panListaMateriaPrima";
            panListaMateriaPrima.Size = new Size(1168, 418);
            panListaMateriaPrima.TabIndex = 2;
            // 
            // dtgTipoMateriaPrima
            // 
            dtgTipoMateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTipoMateriaPrima.Dock = DockStyle.Fill;
            dtgTipoMateriaPrima.Location = new Point(0, 0);
            dtgTipoMateriaPrima.Name = "dtgTipoMateriaPrima";
            dtgTipoMateriaPrima.RowTemplate.Height = 25;
            dtgTipoMateriaPrima.Size = new Size(1168, 418);
            dtgTipoMateriaPrima.TabIndex = 0;
            // 
            // panOpcoes
            // 
            panOpcoes.Dock = DockStyle.Bottom;
            panOpcoes.Location = new Point(0, 518);
            panOpcoes.Name = "panOpcoes";
            panOpcoes.Size = new Size(1168, 100);
            panOpcoes.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblIdTipoMateriaPrima);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtDescricaoTipoMateriaPrima);
            panel1.Controls.Add(lblDescricaoTipoMateriaPrima);
            panel1.Controls.Add(txtNomeTipoMateriaPrima);
            panel1.Controls.Add(lblNomeTipoMateriaPrima);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 100);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(429, 31);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricaoTipoMateriaPrima
            // 
            txtDescricaoTipoMateriaPrima.Location = new Point(126, 60);
            txtDescricaoTipoMateriaPrima.Name = "txtDescricaoTipoMateriaPrima";
            txtDescricaoTipoMateriaPrima.Size = new Size(100, 23);
            txtDescricaoTipoMateriaPrima.TabIndex = 3;
            // 
            // lblDescricaoTipoMateriaPrima
            // 
            lblDescricaoTipoMateriaPrima.AutoSize = true;
            lblDescricaoTipoMateriaPrima.Location = new Point(43, 63);
            lblDescricaoTipoMateriaPrima.Name = "lblDescricaoTipoMateriaPrima";
            lblDescricaoTipoMateriaPrima.Size = new Size(58, 15);
            lblDescricaoTipoMateriaPrima.TabIndex = 2;
            lblDescricaoTipoMateriaPrima.Text = "Descrição";
            // 
            // txtNomeTipoMateriaPrima
            // 
            txtNomeTipoMateriaPrima.Location = new Point(114, 15);
            txtNomeTipoMateriaPrima.Name = "txtNomeTipoMateriaPrima";
            txtNomeTipoMateriaPrima.Size = new Size(100, 23);
            txtNomeTipoMateriaPrima.TabIndex = 1;
            // 
            // lblNomeTipoMateriaPrima
            // 
            lblNomeTipoMateriaPrima.AutoSize = true;
            lblNomeTipoMateriaPrima.Location = new Point(43, 23);
            lblNomeTipoMateriaPrima.Name = "lblNomeTipoMateriaPrima";
            lblNomeTipoMateriaPrima.Size = new Size(40, 15);
            lblNomeTipoMateriaPrima.TabIndex = 0;
            lblNomeTipoMateriaPrima.Text = "Nome";
            // 
            // lblIdTipoMateriaPrima
            // 
            lblIdTipoMateriaPrima.AutoSize = true;
            lblIdTipoMateriaPrima.Location = new Point(616, 57);
            lblIdTipoMateriaPrima.Name = "lblIdTipoMateriaPrima";
            lblIdTipoMateriaPrima.Size = new Size(124, 15);
            lblIdTipoMateriaPrima.TabIndex = 5;
            lblIdTipoMateriaPrima.Text = "lblIdTipoMateriaPrima";
            // 
            // FormMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(PanFundo);
            Name = "FormMateriaPrima";
            Text = "FormMateriaPrima";
            Load += FormMateriaPrima_Load;
            PanFundo.ResumeLayout(false);
            panListaMateriaPrima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgTipoMateriaPrima).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanFundo;
        private Panel panel1;
        private Label lblNomeTipoMateriaPrima;
        private Label lblDescricaoTipoMateriaPrima;
        private TextBox txtNomeTipoMateriaPrima;
        private Panel panListaMateriaPrima;
        private DataGridView dtgTipoMateriaPrima;
        private Panel panOpcoes;
        private Button btnSalvar;
        private TextBox txtDescricaoTipoMateriaPrima;
        private Label lblIdTipoMateriaPrima;
    }
}