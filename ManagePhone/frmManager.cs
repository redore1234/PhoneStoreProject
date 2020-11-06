using ManagePhone.GUI;
using ManagePhone.Models.Models;
using ManagePhone.Views;
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
    public partial class frmManager : Form{
        public EmployeeModel CurEmployeeModel;

        public frmManager() {
            InitializeComponent();  
            //Set custom format for DateTimePicker
            /* this.dtEmployeeDOB.Format = DateTimePickerFormat.Custom;
            this.dtPhoneYear.Format = DateTimePickerFormat.Custom;

            this.dtEmployeeDOB.CustomFormat = "dd-MM-yyyy";
            this.dtPhoneYear.CustomFormat = "dd-MM-yyyy";*/
        }

        public frmManager(EmployeeModel emp):this()
        {
            CurEmployeeModel = emp;
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

        private void pbAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            this.Hide();
            addEmployee.ShowDialog();
            this.Show();
        }

        private void pbViewEmployee_Click(object sender, EventArgs e)
        {
            frmViewEmployee viewEmployee = new frmViewEmployee(CurEmployeeModel);
            this.Hide();
            viewEmployee.ShowDialog();
            this.Show();
        }

        private void pbAddPhone_Click(object sender, EventArgs e)
        {
            frmAddPhone addPhone = new frmAddPhone();
            this.Hide();
            addPhone.ShowDialog();
            this.Show();
        }

        private void pbViewPhone_Click(object sender, EventArgs e)
        {
            frmViewPhone viewPhone = new frmViewPhone();
            this.Hide();
            viewPhone.ShowDialog();
            this.Show();
        }

        private void pbViewCustomer_Click(object sender, EventArgs e)
        {
            frmViewCustomer viewCustomer = new frmViewCustomer();
            this.Hide();
            viewCustomer.ShowDialog();
            this.Show();
        }

        private void pbViewOrder_Click(object sender, EventArgs e)
        {
            frmViewOrder viewOrder = new frmViewOrder();
            this.Hide();
            viewOrder.ShowDialog();
            this.Show();
        }

        private void pbAddOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder addOrder = new frmAddOrder();
            this.Hide();
            addOrder.ShowDialog();
            this.Show();
        }
    }
}
