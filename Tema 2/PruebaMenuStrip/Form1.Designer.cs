namespace PruebaMenuStrip
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_Archivo = new ToolStripMenuItem();
            ToolStripMenuItem_Archivo_Salir = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Dividir = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Multiplicar = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Restar = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Sumar = new ToolStripMenuItem();
            ToolStripMenuItem_AcercaDe = new ToolStripMenuItem();
            txtA = new TextBox();
            contextMenuStripTextA = new ContextMenuStrip(components);
            contextMenuStripTextA_Resetear = new ToolStripMenuItem();
            contextMenuStripTextA_CalcularAleatorio = new ToolStripMenuItem();
            txtB = new TextBox();
            lbl1 = new Label();
            contextMenuStripTextB = new ContextMenuStrip(components);
            contextMenuStripTextB_Resetear = new ToolStripMenuItem();
            contextMenuStripTextB_Random = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStripTextA.SuspendLayout();
            contextMenuStripTextB.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Archivo, ToolStripMenuItem_Operaciones, ToolStripMenuItem_AcercaDe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Archivo
            // 
            ToolStripMenuItem_Archivo.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Archivo_Salir });
            ToolStripMenuItem_Archivo.Name = "ToolStripMenuItem_Archivo";
            ToolStripMenuItem_Archivo.Size = new Size(60, 20);
            ToolStripMenuItem_Archivo.Text = "Archivo";
            // 
            // ToolStripMenuItem_Archivo_Salir
            // 
            ToolStripMenuItem_Archivo_Salir.AutoToolTip = true;
            ToolStripMenuItem_Archivo_Salir.Name = "ToolStripMenuItem_Archivo_Salir";
            ToolStripMenuItem_Archivo_Salir.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem_Archivo_Salir.Size = new Size(136, 22);
            ToolStripMenuItem_Archivo_Salir.Text = "Salir";
            ToolStripMenuItem_Archivo_Salir.ToolTipText = "Con esto cierras el programa!";
            ToolStripMenuItem_Archivo_Salir.Click += ToolStripMenuItem_Archivo_Salir_Click;
            // 
            // ToolStripMenuItem_Operaciones
            // 
            ToolStripMenuItem_Operaciones.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Operaciones_Dividir, ToolStripMenuItem_Operaciones_Multiplicar, ToolStripMenuItem_Operaciones_Restar, ToolStripMenuItem_Operaciones_Sumar });
            ToolStripMenuItem_Operaciones.Name = "ToolStripMenuItem_Operaciones";
            ToolStripMenuItem_Operaciones.Size = new Size(85, 20);
            ToolStripMenuItem_Operaciones.Text = "Operaciones";
            ToolStripMenuItem_Operaciones.ToolTipText = "Sumar los dos numeros";
            // 
            // ToolStripMenuItem_Operaciones_Dividir
            // 
            ToolStripMenuItem_Operaciones_Dividir.Name = "ToolStripMenuItem_Operaciones_Dividir";
            ToolStripMenuItem_Operaciones_Dividir.Size = new Size(218, 22);
            ToolStripMenuItem_Operaciones_Dividir.Text = "Dividir";
            ToolStripMenuItem_Operaciones_Dividir.Click += ToolStripMenuItem_Operaciones_Dividir_Click;
            // 
            // ToolStripMenuItem_Operaciones_Multiplicar
            // 
            ToolStripMenuItem_Operaciones_Multiplicar.Name = "ToolStripMenuItem_Operaciones_Multiplicar";
            ToolStripMenuItem_Operaciones_Multiplicar.Size = new Size(218, 22);
            ToolStripMenuItem_Operaciones_Multiplicar.Text = "Multiplicar";
            ToolStripMenuItem_Operaciones_Multiplicar.Click += ToolStripMenuItem_Operaciones_Multiplicar_Click;
            // 
            // ToolStripMenuItem_Operaciones_Restar
            // 
            ToolStripMenuItem_Operaciones_Restar.Name = "ToolStripMenuItem_Operaciones_Restar";
            ToolStripMenuItem_Operaciones_Restar.Size = new Size(218, 22);
            ToolStripMenuItem_Operaciones_Restar.Text = "Restar";
            ToolStripMenuItem_Operaciones_Restar.Click += ToolStripMenuItem_Operaciones_Restar_Click;
            // 
            // ToolStripMenuItem_Operaciones_Sumar
            // 
            ToolStripMenuItem_Operaciones_Sumar.AutoToolTip = true;
            ToolStripMenuItem_Operaciones_Sumar.Name = "ToolStripMenuItem_Operaciones_Sumar";
            ToolStripMenuItem_Operaciones_Sumar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItem_Operaciones_Sumar.Size = new Size(218, 22);
            ToolStripMenuItem_Operaciones_Sumar.Text = "Sumar";
            ToolStripMenuItem_Operaciones_Sumar.ToolTipText = "Sumar los dos numeros";
            ToolStripMenuItem_Operaciones_Sumar.Click += ToolStripMenuItem_Operaciones_Sumar_Click;
            // 
            // ToolStripMenuItem_AcercaDe
            // 
            ToolStripMenuItem_AcercaDe.Name = "ToolStripMenuItem_AcercaDe";
            ToolStripMenuItem_AcercaDe.Size = new Size(72, 20);
            ToolStripMenuItem_AcercaDe.Text = "Acerca De";
            ToolStripMenuItem_AcercaDe.Click += ToolStripMenuItem_AcercaDe_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = contextMenuStripTextA;
            txtA.Location = new Point(12, 36);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // contextMenuStripTextA
            // 
            contextMenuStripTextA.Items.AddRange(new ToolStripItem[] { contextMenuStripTextA_Resetear, contextMenuStripTextA_CalcularAleatorio });
            contextMenuStripTextA.Name = "contextMenuStripTextA";
            contextMenuStripTextA.Size = new Size(169, 48);
            // 
            // contextMenuStripTextA_Resetear
            // 
            contextMenuStripTextA_Resetear.Name = "contextMenuStripTextA_Resetear";
            contextMenuStripTextA_Resetear.Size = new Size(168, 22);
            contextMenuStripTextA_Resetear.Text = "Resetear";
            contextMenuStripTextA_Resetear.Click += contextMenuStripTextA_Resetear_Click;
            // 
            // contextMenuStripTextA_CalcularAleatorio
            // 
            contextMenuStripTextA_CalcularAleatorio.Name = "contextMenuStripTextA_CalcularAleatorio";
            contextMenuStripTextA_CalcularAleatorio.Size = new Size(168, 22);
            contextMenuStripTextA_CalcularAleatorio.Text = "Calcular Aleatorio";
            contextMenuStripTextA_CalcularAleatorio.Click += contextMenuStripTextA_CalcularAleatorio_Click;
            // 
            // txtB
            // 
            txtB.ContextMenuStrip = contextMenuStripTextB;
            txtB.Location = new Point(12, 65);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(122, 44);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(59, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Resultado";
            // 
            // contextMenuStripTextB
            // 
            contextMenuStripTextB.Items.AddRange(new ToolStripItem[] { contextMenuStripTextB_Resetear, contextMenuStripTextB_Random });
            contextMenuStripTextB.Name = "contextMenuStripTextB";
            contextMenuStripTextB.Size = new Size(120, 48);
            // 
            // contextMenuStripTextB_Resetear
            // 
            contextMenuStripTextB_Resetear.Name = "contextMenuStripTextB_Resetear";
            contextMenuStripTextB_Resetear.Size = new Size(119, 22);
            contextMenuStripTextB_Resetear.Text = "Resetear";
            contextMenuStripTextB_Resetear.Click += resetearToolStripMenuItem_Click;
            // 
            // contextMenuStripTextB_Random
            // 
            contextMenuStripTextB_Random.Name = "contextMenuStripTextB_Random";
            contextMenuStripTextB_Random.Size = new Size(119, 22);
            contextMenuStripTextB_Random.Text = "Random";
            contextMenuStripTextB_Random.Click += randomToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStripTextA.ResumeLayout(false);
            contextMenuStripTextB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_Archivo;
        private ToolStripMenuItem ToolStripMenuItem_Archivo_Salir;
        private ToolStripMenuItem ToolStripMenuItem_Operaciones;
        private ToolStripMenuItem ToolStripMenuItem_Operaciones_Dividir;
        private ToolStripMenuItem ToolStripMenuItem_Operaciones_Multiplicar;
        private ToolStripMenuItem ToolStripMenuItem_Operaciones_Restar;
        private ToolStripMenuItem ToolStripMenuItem_Operaciones_Sumar;
        private ToolStripMenuItem ToolStripMenuItem_AcercaDe;
        private TextBox txtA;
        private TextBox txtB;
        private Label lbl1;
        private ContextMenuStrip contextMenuStripTextA;
        private ToolStripMenuItem contextMenuStripTextA_Resetear;
        private ToolStripMenuItem contextMenuStripTextA_CalcularAleatorio;
        private ContextMenuStrip contextMenuStripTextB;
        private ToolStripMenuItem contextMenuStripTextB_Resetear;
        private ToolStripMenuItem contextMenuStripTextB_Random;
    }
}