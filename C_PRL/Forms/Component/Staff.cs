using B_BUS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms.Component
{
    public partial class Staff : Form
    {
        User currentUser;

        public Staff(User usr)
        {
            InitializeComponent();
            this.currentUser = usr;

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
