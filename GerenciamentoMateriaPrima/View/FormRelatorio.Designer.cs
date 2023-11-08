namespace GerenciamentoMateriaPrima.View
{
    partial class FormRelatorio
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
            panFiltro = new Panel();
            SuspendLayout();
            // 
            // panFiltro
            // 
            panFiltro.Dock = DockStyle.Top;
            panFiltro.Location = new Point(0, 0);
            panFiltro.Name = "panFiltro";
            panFiltro.Size = new Size(1168, 182);
            panFiltro.TabIndex = 0;
            // 
            // FormRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(panFiltro);
            Name = "FormRelatorio";
            Text = "FormRelatorio";
            ResumeLayout(false);
        }

        #endregion

        private Panel panFiltro;
    }
}