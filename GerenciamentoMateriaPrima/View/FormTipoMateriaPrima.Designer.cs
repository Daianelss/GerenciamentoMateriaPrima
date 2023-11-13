﻿namespace GerenciamentoMateriaPrima.View
{
    partial class FormTipoMateriaPrima
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
            panCadastroTipoMateriaPrima = new Panel();
            txtDescricaoTipoMateriaPrima = new TextBox();
            lblDescricaoTipoMateriaPrima = new Label();
            gpbStatus = new GroupBox();
            chkStatus = new CheckBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            txtIdTipoMateriaPrima = new TextBox();
            txtNomeTipoMateriaPrima = new TextBox();
            lblIdTipoMateriaPrima = new Label();
            lblNome = new Label();
            btnPesquisar = new Button();
            dtgTipoMateriaPrima = new DataGridView();
            btnVoltar = new Button();
            panBotoes = new Panel();
            btnAtualizar = new Button();
            panTipoMateriaPrima = new Panel();
            panListaTipoMateriaPrima = new Panel();
            panCadastroTipoMateriaPrima.SuspendLayout();
            gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTipoMateriaPrima).BeginInit();
            panBotoes.SuspendLayout();
            panTipoMateriaPrima.SuspendLayout();
            panListaTipoMateriaPrima.SuspendLayout();
            SuspendLayout();
            // 
            // panCadastroTipoMateriaPrima
            // 
            panCadastroTipoMateriaPrima.Controls.Add(txtDescricaoTipoMateriaPrima);
            panCadastroTipoMateriaPrima.Controls.Add(lblDescricaoTipoMateriaPrima);
            panCadastroTipoMateriaPrima.Controls.Add(gpbStatus);
            panCadastroTipoMateriaPrima.Controls.Add(btnLimpar);
            panCadastroTipoMateriaPrima.Controls.Add(btnSalvar);
            panCadastroTipoMateriaPrima.Controls.Add(txtIdTipoMateriaPrima);
            panCadastroTipoMateriaPrima.Controls.Add(txtNomeTipoMateriaPrima);
            panCadastroTipoMateriaPrima.Controls.Add(lblIdTipoMateriaPrima);
            panCadastroTipoMateriaPrima.Controls.Add(lblNome);
            panCadastroTipoMateriaPrima.Dock = DockStyle.Top;
            panCadastroTipoMateriaPrima.Location = new Point(0, 0);
            panCadastroTipoMateriaPrima.Name = "panCadastroTipoMateriaPrima";
            panCadastroTipoMateriaPrima.Size = new Size(1168, 133);
            panCadastroTipoMateriaPrima.TabIndex = 0;
            // 
            // txtDescricaoTipoMateriaPrima
            // 
            txtDescricaoTipoMateriaPrima.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricaoTipoMateriaPrima.Location = new Point(126, 70);
            txtDescricaoTipoMateriaPrima.Name = "txtDescricaoTipoMateriaPrima";
            txtDescricaoTipoMateriaPrima.Size = new Size(1016, 36);
            txtDescricaoTipoMateriaPrima.TabIndex = 11;
            // 
            // lblDescricaoTipoMateriaPrima
            // 
            lblDescricaoTipoMateriaPrima.AutoSize = true;
            lblDescricaoTipoMateriaPrima.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricaoTipoMateriaPrima.Location = new Point(9, 73);
            lblDescricaoTipoMateriaPrima.Name = "lblDescricaoTipoMateriaPrima";
            lblDescricaoTipoMateriaPrima.Size = new Size(111, 30);
            lblDescricaoTipoMateriaPrima.TabIndex = 10;
            lblDescricaoTipoMateriaPrima.Text = "Descrição:";
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
            // txtIdTipoMateriaPrima
            // 
            txtIdTipoMateriaPrima.Enabled = false;
            txtIdTipoMateriaPrima.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdTipoMateriaPrima.Location = new Point(52, 18);
            txtIdTipoMateriaPrima.Name = "txtIdTipoMateriaPrima";
            txtIdTipoMateriaPrima.Size = new Size(84, 36);
            txtIdTipoMateriaPrima.TabIndex = 1;
            // 
            // txtNomeTipoMateriaPrima
            // 
            txtNomeTipoMateriaPrima.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeTipoMateriaPrima.Location = new Point(256, 21);
            txtNomeTipoMateriaPrima.Name = "txtNomeTipoMateriaPrima";
            txtNomeTipoMateriaPrima.Size = new Size(377, 36);
            txtNomeTipoMateriaPrima.TabIndex = 1;
            // 
            // lblIdTipoMateriaPrima
            // 
            lblIdTipoMateriaPrima.AutoSize = true;
            lblIdTipoMateriaPrima.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdTipoMateriaPrima.Location = new Point(9, 21);
            lblIdTipoMateriaPrima.Name = "lblIdTipoMateriaPrima";
            lblIdTipoMateriaPrima.Size = new Size(37, 30);
            lblIdTipoMateriaPrima.TabIndex = 0;
            lblIdTipoMateriaPrima.Text = "Id:";
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
            // dtgTipoMateriaPrima
            // 
            dtgTipoMateriaPrima.AllowUserToAddRows = false;
            dtgTipoMateriaPrima.AllowUserToDeleteRows = false;
            dtgTipoMateriaPrima.AllowUserToResizeColumns = false;
            dtgTipoMateriaPrima.AllowUserToResizeRows = false;
            dtgTipoMateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTipoMateriaPrima.Dock = DockStyle.Fill;
            dtgTipoMateriaPrima.Location = new Point(20, 20);
            dtgTipoMateriaPrima.MultiSelect = false;
            dtgTipoMateriaPrima.Name = "dtgTipoMateriaPrima";
            dtgTipoMateriaPrima.ReadOnly = true;
            dtgTipoMateriaPrima.RowTemplate.Height = 25;
            dtgTipoMateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTipoMateriaPrima.Size = new Size(1128, 374);
            dtgTipoMateriaPrima.TabIndex = 0;
            dtgTipoMateriaPrima.CellClick += dtgTipoMateriaPrima_CellClick;
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
            // panTipoMateriaPrima
            // 
            panTipoMateriaPrima.Controls.Add(panListaTipoMateriaPrima);
            panTipoMateriaPrima.Controls.Add(panCadastroTipoMateriaPrima);
            panTipoMateriaPrima.Controls.Add(panBotoes);
            panTipoMateriaPrima.Dock = DockStyle.Fill;
            panTipoMateriaPrima.Location = new Point(0, 0);
            panTipoMateriaPrima.Name = "panTipoMateriaPrima";
            panTipoMateriaPrima.Size = new Size(1168, 618);
            panTipoMateriaPrima.TabIndex = 4;
            // 
            // panListaTipoMateriaPrima
            // 
            panListaTipoMateriaPrima.Controls.Add(dtgTipoMateriaPrima);
            panListaTipoMateriaPrima.Dock = DockStyle.Fill;
            panListaTipoMateriaPrima.Location = new Point(0, 133);
            panListaTipoMateriaPrima.Name = "panListaTipoMateriaPrima";
            panListaTipoMateriaPrima.Padding = new Padding(20);
            panListaTipoMateriaPrima.Size = new Size(1168, 414);
            panListaTipoMateriaPrima.TabIndex = 3;
            // 
            // FormTipoMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panTipoMateriaPrima);
            Name = "FormTipoMateriaPrima";
            Text = "FormTipoMateriaPrima";
            Load += FormTipoMateriaPrima_Load;
            panCadastroTipoMateriaPrima.ResumeLayout(false);
            panCadastroTipoMateriaPrima.PerformLayout();
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTipoMateriaPrima).EndInit();
            panBotoes.ResumeLayout(false);
            panTipoMateriaPrima.ResumeLayout(false);
            panListaTipoMateriaPrima.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panCadastroTipoMateriaPrima;
        private GroupBox gpbStatus;
        private CheckBox chkStatus;
        private Button btnLimpar;
        private Button btnSalvar;
        private TextBox txtIdTipoMateriaPrima;
        private TextBox txtNomeTipoMateriaPrima;
        private Label lblIdTipoMateriaPrima;
        private Label lblNome;
        private Button btnPesquisar;
        private DataGridView dtgTipoMateriaPrima;
        private Button btnVoltar;
        private Panel panBotoes;
        private Button btnAtualizar;
        private Panel panTipoMateriaPrima;
        private Panel panListaTipoMateriaPrima;
        private TextBox txtDescricaoTipoMateriaPrima;
        private Label lblDescricaoTipoMateriaPrima;
    }
}