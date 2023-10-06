using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_PRL.Forms.Component;
using B_BUS.Utilities;

namespace C_PRL.Forms
{
    public partial class Dashboard : Form
    {
        User currentUser;

        public Dashboard(User usr)
        {
            InitializeComponent();
            this.currentUser = usr;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products proc = new Products(currentUser);
            FillForm(proc);
        }

        void FillForm(Form form)
        {
            try
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                Size a = new Size(0, 0);
                a = panelContent.Size;

                form.Size = new Size(a.Width, panelContent.Height);
                form.Show();
                panelContent.Controls.Clear();
                panelContent.Controls.Add(form);
            }
            catch
            {
                MessageBox.Show("That bai");
                panelContent.Controls.Clear();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff form = new Staff(currentUser);
            FillForm(form);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer form = new Customer(currentUser);

            FillForm(form);

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Stored form = new Stored(currentUser);
            FillForm(form);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Statistic form = new Statistic(currentUser);
            FillForm(form);
        }
    }
}
