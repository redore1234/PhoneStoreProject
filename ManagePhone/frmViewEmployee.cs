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
    public partial class frmViewEmployee : Form {
        public frmViewEmployee() {
            InitializeComponent();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e) {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
            this.Hide();
            updateEmployee.ShowDialog();
            this.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e) {

        }

        private void btnCancelEmployee_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
