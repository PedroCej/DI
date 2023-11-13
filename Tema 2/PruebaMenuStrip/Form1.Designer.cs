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
            configuracioToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            fondoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem1 = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Dividir = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Multiplicar = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Restar = new ToolStripMenuItem();
            ToolStripMenuItem_Operaciones_Sumar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            habilitarToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_AcercaDe = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            txtA = new TextBox();
            contextMenuStripTextA = new ContextMenuStrip(components);
            contextMenuStripTextA_Resetear = new ToolStripMenuItem();
            contextMenuStripTextA_CalcularAleatorio = new ToolStripMenuItem();
            txtB = new TextBox();
            contextMenuStripTextB = new ContextMenuStrip(components);
            contextMenuStripTextB_Resetear = new ToolStripMenuItem();
            contextMenuStripTextB_Random = new ToolStripMenuItem();
            lbl1 = new Label();
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
            ToolStripMenuItem_Archivo.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Archivo_Salir, configuracioToolStripMenuItem });
            ToolStripMenuItem_Archivo.Name = "ToolStripMenuItem_Archivo";
            ToolStripMenuItem_Archivo.Size = new Size(60, 20);
            ToolStripMenuItem_Archivo.Text = "Archivo";
            // 
            // ToolStripMenuItem_Archivo_Salir
            // 
            ToolStripMenuItem_Archivo_Salir.AutoToolTip = true;
            ToolStripMenuItem_Archivo_Salir.Name = "ToolStripMenuItem_Archivo_Salir";
            ToolStripMenuItem_Archivo_Salir.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem_Archivo_Salir.Size = new Size(180, 22);
            ToolStripMenuItem_Archivo_Salir.Text = "Salir";
            ToolStripMenuItem_Archivo_Salir.ToolTipText = "Con esto cierras el programa!";
            ToolStripMenuItem_Archivo_Salir.Click += ToolStripMenuItem_Archivo_Salir_Click;
            // 
            // configuracioToolStripMenuItem
            // 
            configuracioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fuenteToolStripMenuItem });
            configuracioToolStripMenuItem.Name = "configuracioToolStripMenuItem";
            configuracioToolStripMenuItem.Size = new Size(180, 22);
            configuracioToolStripMenuItem.Text = "Configuración";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fondoToolStripMenuItem, fuenteToolStripMenuItem1 });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // fondoToolStripMenuItem
            // 
            fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
            fondoToolStripMenuItem.Size = new Size(110, 22);
            fondoToolStripMenuItem.Text = "Fondo";
            fondoToolStripMenuItem.Click += fondoToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem1
            // 
            fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            fuenteToolStripMenuItem1.Size = new Size(110, 22);
            fuenteToolStripMenuItem1.Text = "Fuente";
            fuenteToolStripMenuItem1.Click += fuenteToolStripMenuItem1_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(180, 22);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_Operaciones
            // 
            ToolStripMenuItem_Operaciones.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Operaciones_Dividir, ToolStripMenuItem_Operaciones_Multiplicar, ToolStripMenuItem_Operaciones_Restar, ToolStripMenuItem_Operaciones_Sumar, toolStripSeparator1, habilitarToolStripMenuItem });
            ToolStripMenuItem_Operaciones.Name = "ToolStripMenuItem_Operaciones";
            ToolStripMenuItem_Operaciones.Size = new Size(85, 20);
            ToolStripMenuItem_Operaciones.Text = "Operaciones";
            ToolStripMenuItem_Operaciones.ToolTipText = "Sumar los dos numeros";
            // 
            // ToolStripMenuItem_Operaciones_Dividir
            // 
            ToolStripMenuItem_Operaciones_Dividir.Name = "ToolStripMenuItem_Operaciones_Dividir";
            ToolStripMenuItem_Operaciones_Dividir.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D;
            ToolStripMenuItem_Operaciones_Dividir.Size = new Size(246, 22);
            ToolStripMenuItem_Operaciones_Dividir.Text = "Dividir";
            ToolStripMenuItem_Operaciones_Dividir.Click += ToolStripMenuItem_Operaciones_Dividir_Click;
            // 
            // ToolStripMenuItem_Operaciones_Multiplicar
            // 
            ToolStripMenuItem_Operaciones_Multiplicar.Name = "ToolStripMenuItem_Operaciones_Multiplicar";
            ToolStripMenuItem_Operaciones_Multiplicar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
            ToolStripMenuItem_Operaciones_Multiplicar.Size = new Size(246, 22);
            ToolStripMenuItem_Operaciones_Multiplicar.Text = "Multiplicar";
            ToolStripMenuItem_Operaciones_Multiplicar.Click += ToolStripMenuItem_Operaciones_Multiplicar_Click;
            // 
            // ToolStripMenuItem_Operaciones_Restar
            // 
            ToolStripMenuItem_Operaciones_Restar.Name = "ToolStripMenuItem_Operaciones_Restar";
            ToolStripMenuItem_Operaciones_Restar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            ToolStripMenuItem_Operaciones_Restar.Size = new Size(246, 22);
            ToolStripMenuItem_Operaciones_Restar.Text = "Restar";
            ToolStripMenuItem_Operaciones_Restar.Click += ToolStripMenuItem_Operaciones_Restar_Click;
            // 
            // ToolStripMenuItem_Operaciones_Sumar
            // 
            ToolStripMenuItem_Operaciones_Sumar.AutoToolTip = true;
            ToolStripMenuItem_Operaciones_Sumar.Name = "ToolStripMenuItem_Operaciones_Sumar";
            ToolStripMenuItem_Operaciones_Sumar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItem_Operaciones_Sumar.Size = new Size(246, 22);
            ToolStripMenuItem_Operaciones_Sumar.Text = "Sumar";
            ToolStripMenuItem_Operaciones_Sumar.ToolTipText = "Sumar los dos numeros";
            ToolStripMenuItem_Operaciones_Sumar.Click += ToolStripMenuItem_Operaciones_Sumar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(243, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            habilitarToolStripMenuItem.Checked = true;
            habilitarToolStripMenuItem.CheckOnClick = true;
            habilitarToolStripMenuItem.CheckState = CheckState.Checked;
            habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            habilitarToolStripMenuItem.Size = new Size(246, 22);
            habilitarToolStripMenuItem.Text = "Habilitar";
            habilitarToolStripMenuItem.Click += habilitarToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_AcercaDe
            // 
            ToolStripMenuItem_AcercaDe.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ToolStripMenuItem_AcercaDe.Name = "ToolStripMenuItem_AcercaDe";
            ToolStripMenuItem_AcercaDe.Size = new Size(53, 20);
            ToolStripMenuItem_AcercaDe.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            acercaDeToolStripMenuItem.Size = new Size(173, 22);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = contextMenuStripTextA;
            txtA.Location = new Point(12, 36);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
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
            txtB.TextAlign = HorizontalAlignment.Right;
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(122, 44);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(59, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Resultado";
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
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ToolStripMenuItem configuracioToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fondoToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem1;
        private ToolStripMenuItem fuenteToolStripMenuItem;
    }
}