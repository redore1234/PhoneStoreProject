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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to close the program?","Notice", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }    
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            frmManager manager = new frmManager();
            //frmEmployee staff = new frmEmployee();
            this.Hide();
            //staff.ShowDialog();
            manager.ShowDialog();
            this.Show();
        }
    }
}
