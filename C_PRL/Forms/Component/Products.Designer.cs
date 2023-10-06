namespace C_PRL.Forms.Component
{
    partial class Products
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
            tabProductList = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            button4 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1573, 631);
            tabControl1.TabIndex = 0;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(tableLayoutPanel1);
            tabProductList.Location = new Point(4, 24);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(1565, 603);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Danh sách sản phẩm";
            tabProductList.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Size = new Size(1559, 597);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 191);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(296, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 22);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(296, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 22);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(815, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 132);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 150, 243);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(296, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 22);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(769, 79);
            label4.Name = "label4";
            label4.Size = new Size(40, 14);
            label4.TabIndex = 5;
            label4.Text = "Mô Tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 97);
            label1.Name = "label1";
            label1.Size = new Size(25, 14);
            label1.TabIndex = 2;
            label1.Text = "Giá";
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
            lblName.Location = new Point(216, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(26, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Tên";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(3, 200);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(1139, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 191);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 204);
            label5.Name = "label5";
            label5.Size = new Size(66, 14);
            label5.TabIndex = 11;
            label5.Text = "Đang chọn";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 64, 129);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(33, 111);
            button4.Name = "button4";
            button4.Size = new Size(366, 39);
            button4.TabIndex = 2;
            button4.Text = "Xoá dữ liệu nhập";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 191, 165);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(33, 41);
            button2.Name = "button2";
            button2.Size = new Size(366, 39);
            button2.TabIndex = 1;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 229);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1553, 365);
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
            dataGridView1.Size = new Size(1547, 343);
            dataGridView1.TabIndex = 1;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(1573, 631);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TabPage tabProductList;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblName;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button button2;
        private Label label5;
        private Button button4;
    }
}