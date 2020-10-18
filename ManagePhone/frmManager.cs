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
            //Set custom format for DateTimePicker
            /*            this.dtEmployeeDOB.Format = DateTimePickerFormat.Custom;
                        this.dtPhoneYear.Format = DateTimePickerFormat.Custom;

                        this.dtEmployeeDOB.CustomFormat = "dd-MM-yyyy";
                        this.dtPhoneYear.CustomFormat = "dd-MM-yyyy";*/
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

        private void lbAddEmployee_Click(object sender, EventArgs e) {
            frmAddEmployee addEmployee = new frmAddEmployee();
            this.Hide();
            addEmployee.ShowDialog();
            this.Show();
        }

        private void lbViewEmployee_Click(object sender, EventArgs e) {
            frmViewEmployee viewEmployee = new frmViewEmployee();
            this.Hide();
            viewEmployee.ShowDialog();
            this.Show();
        }

        private void lbViewPhone_Click(object sender, EventArgs e) {
            frmViewPhone viewPhone = new frmViewPhone();
            this.Hide();
            viewPhone.ShowDialog();
            this.Show();
        }

        private void lbViewBill_Click(object sender, EventArgs e) {
            frmViewBill viewBill = new frmViewBill();
            this.Hide();
            viewBill.ShowDialog();
            this.Show();
        }

        private void lbViewCustomer_Click(object sender, EventArgs e) {
            frmViewCustomer viewCustomer = new frmViewCustomer();
            this.Hide();
            viewCustomer.ShowDialog();
            this.Show();
        }

        private void lbAddPhone_Click(object sender, EventArgs e) {
            frmAddPhone addPhone = new frmAddPhone();
            this.Hide();
            addPhone.ShowDialog();
            this.Show();
        }
    }
}
