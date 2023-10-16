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
            SuspendLayout();
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(81, 37);
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
            rdb2.Location = new Point(81, 73);
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
            rdb3.Location = new Point(81, 110);
            rdb3.Name = "rdb3";
            rdb3.Size = new Size(78, 19);
            rdb3.TabIndex = 2;
            rdb3.TabStop = true;
            rdb3.Text = "1024 * 768";
            rdb3.UseVisualStyleBackColor = true;
            rdb3.Click += rdb3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdb3);
            Controls.Add(rdb2);
            Controls.Add(rdb1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdb1;
        private RadioButton rdb2;
        private RadioButton rdb3;
    }
}