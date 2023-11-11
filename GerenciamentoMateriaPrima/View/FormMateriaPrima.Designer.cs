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
            SuspendLayout();
            // 
            // PanFundo
            // 
            PanFundo.Location = new Point(233, 354);
            PanFundo.Name = "PanFundo";
            PanFundo.Size = new Size(200, 100);
            PanFundo.TabIndex = 0;
            // 
            // FormMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 618);
            Controls.Add(PanFundo);
            Name = "FormMateriaPrima";
            Text = "FormMateriaPrima";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanFundo;
    }
}