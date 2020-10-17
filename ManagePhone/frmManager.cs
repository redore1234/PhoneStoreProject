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
            this.MinimumSize = this.Size;
        }

        private void btnViewEmployee_Click(object sender, EventArgs e) {
            frmViewEmployee viewEmployee = new frmViewEmployee();
            this.Hide();
            viewEmployee.ShowDialog();
            this.Show();
        }

        private void btnViewBill_Click(object sender, EventArgs e) {
            frmViewBill viewBill = new frmViewBill();
            this.Hide();
            viewBill.ShowDialog();
            this.Show();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e) {
            frmViewCustomer viewCustomer = new frmViewCustomer();
            this.Hide();
            viewCustomer.ShowDialog();
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

        private void btnImagePhone_Click(object sender, EventArgs e) {

        }

        private void pbImage_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
