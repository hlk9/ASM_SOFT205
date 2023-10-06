namespace C_PRL.Forms
{
    partial class Dashboard
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
            panelSideBar = new Panel();
            btnReport = new Button();
            btnStaff = new Button();
            btnStore = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnHome = new Button();
            panelContent = new Panel();
            panelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSideBar.BackColor = Color.FromArgb(178, 223, 219);
            panelSideBar.Controls.Add(btnReport);
            panelSideBar.Controls.Add(btnStaff);
            panelSideBar.Controls.Add(btnStore);
            panelSideBar.Controls.Add(btnCustomer);
            panelSideBar.Controls.Add(btnProduct);
            panelSideBar.Controls.Add(btnHome);
            panelSideBar.Location = new Point(-2, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(172, 570);
            panelSideBar.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(0, 150, 136);
            btnReport.FlatAppearance.BorderColor = Color.Teal;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(0, 435);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(169, 47);
            btnReport.TabIndex = 5;
            btnReport.Text = "Thống kê";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(0, 150, 136);
            btnStaff.FlatAppearance.BorderColor = Color.Teal;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(0, 357);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(169, 47);
            btnStaff.TabIndex = 4;
            btnStaff.Text = "Nhân viên";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnStore
            // 
            btnStore.BackColor = Color.FromArgb(0, 150, 136);
            btnStore.FlatAppearance.BorderColor = Color.Teal;
            btnStore.FlatAppearance.BorderSize = 0;
            btnStore.FlatStyle = FlatStyle.Flat;
            btnStore.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStore.ForeColor = Color.White;
            btnStore.Location = new Point(0, 279);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(169, 47);
            btnStore.TabIndex = 3;
            btnStore.Text = "Kho";
            btnStore.UseVisualStyleBackColor = false;
            btnStore.Click += btnStore_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(0, 150, 136);
            btnCustomer.FlatAppearance.BorderColor = Color.Teal;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(0, 202);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(169, 47);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Khách Hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(0, 150, 136);
            btnProduct.FlatAppearance.BorderColor = Color.Teal;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(0, 126);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(169, 47);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 150, 136);
            btnHome.FlatAppearance.BorderColor = Color.Teal;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 50);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 47);
            btnHome.TabIndex = 0;
            btnHome.Text = "Trang Chủ";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.FromArgb(224, 242, 241);
            panelContent.Location = new Point(167, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(633, 570);
            panelContent.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(panelContent);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel panelContent;
        private Button btnStaff;
        private Button btnStore;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnHome;
        private Button btnReport;
    }
}