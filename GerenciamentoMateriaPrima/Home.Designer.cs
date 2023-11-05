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
            dtgTeste = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgTeste).BeginInit();
            SuspendLayout();
            // 
            // dtgTeste
            // 
            dtgTeste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTeste.Location = new Point(12, 30);
            dtgTeste.Name = "dtgTeste";
            dtgTeste.RowTemplate.Height = 25;
            dtgTeste.Size = new Size(776, 231);
            dtgTeste.TabIndex = 0;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgTeste);
            Name = "formHome";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTeste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgTeste;
    }
}