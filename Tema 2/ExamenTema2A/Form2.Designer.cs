namespace ExamenTema2A
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido1 = new TextBox();
            txtApellido2 = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(51, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Location = new Point(51, 68);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Apellido";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new Point(51, 97);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Segundo Apellido";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Location = new Point(51, 126);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(167, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(167, 60);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(308, 23);
            txtApellido1.TabIndex = 5;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(167, 89);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(308, 23);
            txtApellido2.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(167, 118);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(308, 23);
            txtTelefono.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(549, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(549, 64);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 180);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido2);
            Controls.Add(txtApellido1);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido1;
        private TextBox txtApellido2;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}