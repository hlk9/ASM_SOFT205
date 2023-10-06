namespace C_PRL.Forms.Component
{
    partial class Staff
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
            tabStaffList = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabStaffList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStaffList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1139, 811);
            tabControl1.TabIndex = 0;
            // 
            // tabStaffList
            // 
            tabStaffList.Controls.Add(tableLayoutPanel1);
            tabStaffList.Location = new Point(4, 24);
            tabStaffList.Name = "tabStaffList";
            tabStaffList.Padding = new Padding(3);
            tabStaffList.Size = new Size(1131, 783);
            tabStaffList.TabIndex = 0;
            tabStaffList.Text = "Danh sách Nhân viên";
            tabStaffList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.9026F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0974F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.78261F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.2173843F));
            tableLayoutPanel1.Size = new Size(1125, 777);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 254);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(122, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 22);
            textBox2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(31, 153);
            label8.Name = "label8";
            label8.Size = new Size(44, 14);
            label8.TabIndex = 17;
            label8.Text = "Địa chỉ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(33, 150, 243);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(561, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 22);
            comboBox2.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(561, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 22);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 208);
            label7.Name = "label7";
            label7.Size = new Size(62, 14);
            label7.TabIndex = 12;
            label7.Text = "Ngày sinh";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(476, 100);
            label6.Name = "label6";
            label6.Size = new Size(38, 14);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(122, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 22);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(122, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 22);
            textBox3.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 150, 243);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(561, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 22);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(561, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 22);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(476, 44);
            label4.Name = "label4";
            label4.Size = new Size(52, 14);
            label4.TabIndex = 5;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(476, 151);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 4;
            label3.Text = "Vai trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(465, 205);
            label2.Name = "label2";
            label2.Size = new Size(79, 14);
            label2.TabIndex = 3;
            label2.Text = "Số Điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 100);
            label1.Name = "label1";
            label1.Size = new Size(43, 14);
            label1.TabIndex = 2;
            label1.Text = "Họ tên";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(30, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Mã Nhân viên";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(3, 263);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(823, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 254);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 219);
            label5.Name = "label5";
            label5.Size = new Size(66, 14);
            label5.TabIndex = 11;
            label5.Text = "Đang chọn";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(0, 191, 165);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(160, 111);
            button3.Name = "button3";
            button3.Size = new Size(121, 39);
            button3.TabIndex = 3;
            button3.Text = "Xoá Dữ liệu";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 64, 129);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(33, 112);
            button4.Name = "button4";
            button4.Size = new Size(121, 39);
            button4.TabIndex = 2;
            button4.Text = "Xoá";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 191, 165);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(160, 41);
            button2.Name = "button2";
            button2.Size = new Size(121, 39);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 191, 165);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 41);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1119, 482);
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
            dataGridView1.Size = new Size(1113, 460);
            dataGridView1.TabIndex = 1;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(1139, 811);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Text = "Products";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabStaffList.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabStaffList;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblName;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label5;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Label label7;
        private Label label6;
        private TextBox textBox2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}