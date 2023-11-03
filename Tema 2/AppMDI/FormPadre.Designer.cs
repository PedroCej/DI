namespace AppMDI
{
    partial class FormPadre
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
            menuStrip1 = new MenuStrip();
            MenuItem_Nuevo = new ToolStripMenuItem();
            MenuItem_Ventana = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItem_Nuevo, MenuItem_Ventana });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = MenuItem_Ventana;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1214, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip";
            // 
            // MenuItem_Nuevo
            // 
            MenuItem_Nuevo.Name = "MenuItem_Nuevo";
            MenuItem_Nuevo.Size = new Size(54, 20);
            MenuItem_Nuevo.Text = "Nuevo";
            MenuItem_Nuevo.Click += MenuItem_Nuevo_Click;
            // 
            // MenuItem_Ventana
            // 
            MenuItem_Ventana.Name = "MenuItem_Ventana";
            MenuItem_Ventana.Size = new Size(61, 20);
            MenuItem_Ventana.Text = "Ventana";
            // 
            // FormPadre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 551);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPadre";
            Text = "Este s el formulario MDI (Form contenedor)";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem_Nuevo;
        private ToolStripMenuItem MenuItem_Ventana;
    }
}