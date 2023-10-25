namespace Forms2
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
            btn = new Button();
            label1 = new Label();
            botonModal = new Button();
            button1 = new Button();
            txtMensaje = new TextBox();
            btn3 = new Button();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(569, 46);
            btn.Name = "btn";
            btn.Size = new Size(174, 25);
            btn.TabIndex = 0;
            btn.Text = "Cambiar color a rojo";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // botonModal
            // 
            botonModal.Location = new Point(41, 60);
            botonModal.Name = "botonModal";
            botonModal.Size = new Size(75, 23);
            botonModal.TabIndex = 2;
            botonModal.Text = "button1";
            botonModal.UseVisualStyleBackColor = true;
            botonModal.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(318, 105);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 3;
            button1.Text = "Segundo Formulario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(246, 140);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(278, 23);
            txtMensaje.TabIndex = 4;
            // 
            // btn3
            // 
            btn3.Location = new Point(33, 348);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 23);
            btn3.TabIndex = 5;
            btn3.Text = "Elegir tamaño";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btn3);
            Controls.Add(txtMensaje);
            Controls.Add(button1);
            Controls.Add(botonModal);
            Controls.Add(label1);
            Controls.Add(btn);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
            MouseEnter += Form1_MouseEnter;
            MouseLeave += Form1_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Label label1;
        private Button botonModal;
        private Button button1;
        private TextBox txtMensaje;
        private Button btn3;
    }
}