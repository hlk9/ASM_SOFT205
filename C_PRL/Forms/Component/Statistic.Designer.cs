namespace C_PRL.Forms.Component
{
    partial class Statistic
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
            tabControl1 = new TabControl();
            tabImportList = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            groupBox2 = new GroupBox();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox10 = new TextBox();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabImportList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabImportList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1331, 853);
            tabControl1.TabIndex = 0;
            // 
            // tabImportList
            // 
            tabImportList.Controls.Add(tableLayoutPanel1);
            tabImportList.Location = new Point(4, 24);
            tabImportList.Name = "tabImportList";
            tabImportList.Padding = new Padding(3);
            tabImportList.Size = new Size(1323, 825);
            tabImportList.TabIndex = 0;
            tabImportList.Text = "Danh sách nhập kho";
            tabImportList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.9026F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0974F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.78261F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.2173843F));
            tableLayoutPanel1.Size = new Size(1317, 819);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 223, 219);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 29);
            panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(33, 150, 243);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tên", "Nhân viên", "Giá nhỏ hơn", "Giá lớn hơn" });
            comboBox2.Location = new Point(208, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 22);
            comboBox2.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 266);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(706, 136);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(242, 22);
            textBox6.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(627, 139);
            label6.Name = "label6";
            label6.Size = new Size(67, 14);
            label6.TabIndex = 13;
            label6.Text = "Ngày nhập";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(315, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 22);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(315, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 22);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(706, 37);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 68);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(315, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 22);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(627, 66);
            label4.Name = "label4";
            label4.Size = new Size(40, 14);
            label4.TabIndex = 5;
            label4.Text = "Mô Tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(219, 136);
            label2.Name = "label2";
            label2.Size = new Size(86, 14);
            label2.TabIndex = 3;
            label2.Text = "Số lượng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 91);
            label1.Name = "label1";
            label1.Size = new Size(58, 14);
            label1.TabIndex = 2;
            label1.Text = "Giá Nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 184);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(218, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(26, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(963, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 266);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khác";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(89, 179);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(256, 22);
            textBox9.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 182);
            label9.Name = "label9";
            label9.Size = new Size(49, 14);
            label9.TabIndex = 15;
            label9.Text = "Giá bán";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(89, 130);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(257, 22);
            textBox8.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 136);
            label8.Name = "label8";
            label8.Size = new Size(46, 14);
            label8.TabIndex = 15;
            label8.Text = "Đã bán";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(90, 83);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(257, 22);
            textBox7.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 88);
            label7.Name = "label7";
            label7.Size = new Size(45, 14);
            label7.TabIndex = 13;
            label7.Text = "Họ Tên";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(89, 36);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 22);
            textBox5.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 41);
            label3.Name = "label3";
            label3.Size = new Size(82, 14);
            label3.TabIndex = 11;
            label3.Text = "Mã Nhân viên";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 231);
            label5.Name = "label5";
            label5.Size = new Size(65, 14);
            label5.TabIndex = 11;
            label5.Text = "Đang chọn";
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 310);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1311, 506);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1305, 484);
            dataGridView1.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(497, 223);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(242, 22);
            textBox10.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(341, 229);
            label10.Name = "label10";
            label10.Size = new Size(150, 15);
            label10.TabIndex = 15;
            label10.Text = "Tổng số lượng trong KHO";
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(1331, 853);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statistic";
            Text = "Products";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabImportList.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabImportList;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblName;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label3;
        private Panel panel1;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
    }
}