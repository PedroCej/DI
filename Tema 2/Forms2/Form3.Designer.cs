namespace Forms2
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
            rdb1 = new RadioButton();
            rdb2 = new RadioButton();
            rdb3 = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(16, 65);
            rdb1.Name = "rdb1";
            rdb1.Size = new Size(72, 19);
            rdb1.TabIndex = 0;
            rdb1.TabStop = true;
            rdb1.Text = "640 * 480";
            rdb1.UseVisualStyleBackColor = true;
            rdb1.Click += rdb1_Click;
            // 
            // rdb2
            // 
            rdb2.AutoSize = true;
            rdb2.Location = new Point(16, 101);
            rdb2.Name = "rdb2";
            rdb2.Size = new Size(72, 19);
            rdb2.TabIndex = 1;
            rdb2.TabStop = true;
            rdb2.Text = "800 * 600";
            rdb2.UseVisualStyleBackColor = true;
            rdb2.Click += rdb2_Click;
            // 
            // rdb3
            // 
            rdb3.AutoSize = true;
            rdb3.Location = new Point(16, 138);
            rdb3.Name = "rdb3";
            rdb3.Size = new Size(78, 19);
            rdb3.TabIndex = 2;
            rdb3.TabStop = true;
            rdb3.Text = "1024 * 768";
            rdb3.UseVisualStyleBackColor = true;
            rdb3.Click += rdb3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(434, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rdb2);
            panel2.Controls.Add(rdb1);
            panel2.Controls.Add(rdb3);
            panel2.Location = new Point(38, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 178);
            panel2.TabIndex = 4;
            panel2.Tag = "Resolución";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Resolución";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Ventana";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Normal";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Maximizar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdb1;
        private RadioButton rdb2;
        private RadioButton rdb3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
    }
}