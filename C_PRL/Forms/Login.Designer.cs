namespace C_PRL.Forms
{
    partial class Login
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(221, 135);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tài khoản";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(136, 136);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(136, 183);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(221, 183);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập mật khẩu";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Help;
            label3.Font = new Font("Roboto", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(376, 223);
            label3.Name = "label3";
            label3.Size = new Size(89, 14);
            label3.TabIndex = 4;
            label3.Text = "Quên mật khẩu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(231, 62);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 5;
            label4.Text = "Đăng nhập để tiếp tục";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderColor = Color.LightGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(221, 260);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 6;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(349, 260);
            button2.Name = "button2";
            button2.Size = new Size(116, 41);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(698, 387);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Login";
            Text = "Login for Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}