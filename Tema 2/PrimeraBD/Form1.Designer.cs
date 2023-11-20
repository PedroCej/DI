namespace PrimeraBD
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
            dataGridView1 = new DataGridView();
            Conectar = new GroupBox();
            btnConectar = new Button();
            lblPort = new Label();
            lblServer = new Label();
            lblPasswd = new Label();
            lblUser = new Label();
            txtPort = new TextBox();
            txtServer = new TextBox();
            txtPasswd = new TextBox();
            txtUser = new TextBox();
            Insertar = new GroupBox();
            btnInsertar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Conectar.SuspendLayout();
            Insertar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(741, 162);
            dataGridView1.TabIndex = 0;
            // 
            // Conectar
            // 
            Conectar.Controls.Add(btnConectar);
            Conectar.Controls.Add(lblPort);
            Conectar.Controls.Add(lblServer);
            Conectar.Controls.Add(lblPasswd);
            Conectar.Controls.Add(lblUser);
            Conectar.Controls.Add(txtPort);
            Conectar.Controls.Add(txtServer);
            Conectar.Controls.Add(txtPasswd);
            Conectar.Controls.Add(txtUser);
            Conectar.Location = new Point(27, 12);
            Conectar.Name = "Conectar";
            Conectar.Size = new Size(309, 189);
            Conectar.TabIndex = 1;
            Conectar.TabStop = false;
            Conectar.Text = "Conectar";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(34, 146);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(237, 31);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(50, 117);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(42, 15);
            lblPort.TabIndex = 7;
            lblPort.Text = "Puerto";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(34, 88);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(63, 15);
            lblServer.TabIndex = 6;
            lblServer.Text = "IP Servidor";
            // 
            // lblPasswd
            // 
            lblPasswd.AutoSize = true;
            lblPasswd.Location = new Point(30, 59);
            lblPasswd.Name = "lblPasswd";
            lblPasswd.Size = new Size(67, 15);
            lblPasswd.TabIndex = 5;
            lblPasswd.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(50, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuario";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(103, 109);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(168, 23);
            txtPort.TabIndex = 3;
            txtPort.Text = "3306";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(103, 80);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(168, 23);
            txtServer.TabIndex = 2;
            txtServer.Text = "localhost";
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(103, 51);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.Size = new Size(168, 23);
            txtPasswd.TabIndex = 1;
            txtPasswd.Text = "root";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(103, 22);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(168, 23);
            txtUser.TabIndex = 0;
            txtUser.Text = "root";
            // 
            // Insertar
            // 
            Insertar.Controls.Add(btnInsertar);
            Insertar.Controls.Add(label9);
            Insertar.Controls.Add(label8);
            Insertar.Controls.Add(label7);
            Insertar.Controls.Add(label6);
            Insertar.Controls.Add(label5);
            Insertar.Controls.Add(txtDNI);
            Insertar.Controls.Add(txtNombre);
            Insertar.Controls.Add(txtApellidos);
            Insertar.Controls.Add(txtTelefono);
            Insertar.Controls.Add(txtEmail);
            Insertar.Location = new Point(359, 12);
            Insertar.Name = "Insertar";
            Insertar.Size = new Size(409, 189);
            Insertar.TabIndex = 2;
            Insertar.TabStop = false;
            Insertar.Text = "Insertar";
            // 
            // btnInsertar
            // 
            btnInsertar.Enabled = false;
            btnInsertar.Location = new Point(286, 56);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(90, 76);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 146);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 12;
            label9.Text = "e-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 117);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 11;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 88);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 10;
            label7.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 59);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 30);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(92, 22);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(168, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(92, 80);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(168, 23);
            txtApellidos.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(92, 109);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(168, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 8;
            // 
            // btnMostrar
            // 
            btnMostrar.Enabled = false;
            btnMostrar.Location = new Point(199, 207);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(361, 52);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(Insertar);
            Controls.Add(Conectar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Conectar.ResumeLayout(false);
            Conectar.PerformLayout();
            Insertar.ResumeLayout(false);
            Insertar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox Conectar;
        private Label lblPort;
        private Label lblServer;
        private Label lblPasswd;
        private Label lblUser;
        private TextBox txtPort;
        private TextBox txtServer;
        private TextBox txtPasswd;
        private TextBox txtUser;
        private GroupBox Insertar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnConectar;
        private Button btnInsertar;
        private Button btnMostrar;
    }
}