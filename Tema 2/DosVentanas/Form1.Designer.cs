namespace DosVentanas
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
            txtUser = new TextBox();
            txtPasswd = new TextBox();
            txtServer = new TextBox();
            txtPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(30, 28);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            txtUser.Text = "root";
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(30, 57);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.Size = new Size(100, 23);
            txtPasswd.TabIndex = 1;
            txtPasswd.Text = "root";
            txtPasswd.UseSystemPasswordChar = true;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(30, 86);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(100, 23);
            txtServer.TabIndex = 2;
            txtServer.Text = "localhost";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(30, 115);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 3;
            txtPort.Text = "3306";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 36);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 94);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "IP Server";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 123);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Port";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(55, 144);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConectar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPort);
            Controls.Add(txtServer);
            Controls.Add(txtPasswd);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPasswd;
        private TextBox txtServer;
        private TextBox txtPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConectar;
    }
}