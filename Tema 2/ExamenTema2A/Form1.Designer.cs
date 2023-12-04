namespace ExamenTema2A
{
    partial class Form1
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
            ToolStripMenuItemInsertar = new ToolStripMenuItem();
            ToolStripMenuItemEliminar = new ToolStripMenuItem();
            ToolStripMenuItemMostrar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemInsertar, ToolStripMenuItemEliminar, ToolStripMenuItemMostrar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemInsertar
            // 
            ToolStripMenuItemInsertar.Name = "ToolStripMenuItemInsertar";
            ToolStripMenuItemInsertar.Size = new Size(58, 20);
            ToolStripMenuItemInsertar.Text = "Insertar";
            ToolStripMenuItemInsertar.Click += ToolStripMenuItemInsertar_Click;
            // 
            // ToolStripMenuItemEliminar
            // 
            ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar";
            ToolStripMenuItemEliminar.Size = new Size(62, 20);
            ToolStripMenuItemEliminar.Text = "Eliminar";
            ToolStripMenuItemEliminar.Click += ToolStripMenuItemEliminar_Click;
            // 
            // ToolStripMenuItemMostrar
            // 
            ToolStripMenuItemMostrar.Name = "ToolStripMenuItemMostrar";
            ToolStripMenuItemMostrar.Size = new Size(60, 20);
            ToolStripMenuItemMostrar.Text = "Mostrar";
            ToolStripMenuItemMostrar.Click += ToolStripMenuItemMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItemInsertar;
        private ToolStripMenuItem ToolStripMenuItemEliminar;
        private ToolStripMenuItem ToolStripMenuItemMostrar;
    }
}