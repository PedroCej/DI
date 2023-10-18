namespace Forms2
{
    partial class SegundoFormulario
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
            etiquetaForm2 = new Label();
            SuspendLayout();
            // 
            // etiquetaForm2
            // 
            etiquetaForm2.AutoSize = true;
            etiquetaForm2.Location = new Point(23, 19);
            etiquetaForm2.Name = "etiquetaForm2";
            etiquetaForm2.Size = new Size(187, 15);
            etiquetaForm2.TabIndex = 0;
            etiquetaForm2.Text = "Estamos en el segundo formulario";
            // 
            // SegundoFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(etiquetaForm2);
            Name = "SegundoFormulario";
            Text = "SegundoFormulario";
            FormClosed += SegundoFormulario_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiquetaForm2;
    }
}