namespace ExamenTema2A
{
    partial class Form3
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
            btnCerrar = new Button();
            txtTelefono = new TextBox();
            txtApellido2 = new TextBox();
            txtApellido1 = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(346, 43);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(176, 122);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 17;
            // 
            // txtApellido2
            // 
            txtApellido2.Enabled = false;
            txtApellido2.Location = new Point(176, 93);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(100, 23);
            txtApellido2.TabIndex = 16;
            // 
            // txtApellido1
            // 
            txtApellido1.Enabled = false;
            txtApellido1.Location = new Point(176, 64);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(100, 23);
            txtApellido1.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(176, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 14;
            // 
            // label4
            // 
            label4.Location = new Point(60, 130);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new Point(60, 101);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 12;
            label3.Text = "Segundo Apellido";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Location = new Point(60, 72);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 11;
            label2.Text = "Primer Apellido";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Location = new Point(60, 43);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido2);
            Controls.Add(txtApellido1);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private TextBox txtTelefono;
        private TextBox txtApellido2;
        private TextBox txtApellido1;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}