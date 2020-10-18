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
    public partial class frmManager : Form {
        public frmManager() {
            InitializeComponent();
        }

        private void btnViewEmployee_Click(object sender, EventArgs e) {
            frmViewEmployee viewEmployee = new frmViewEmployee();
            this.Hide();
            viewEmployee.ShowDialog();
            this.Show();
        }

        private void btnViewPhoneDetails_Click(object sender, EventArgs e) {
            frmViewPhone viewPhone = new frmViewPhone();
            this.Hide();
            viewPhone.ShowDialog();
            this.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) {

        }

        private void btnAddPhone_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
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
    }
}
