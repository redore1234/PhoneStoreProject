using ManagePhone.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmEmployee : Form {
        public frmEmployee() {
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e) {
            frmCheckout checkout = new frmCheckout();
            this.Hide();
            checkout.ShowDialog();
            this.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            frmAddCustomer addCustomer = new frmAddCustomer();
            this.Hide();
            addCustomer.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
