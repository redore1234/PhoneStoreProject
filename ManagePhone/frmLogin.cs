using ManagePhone.Presenters;
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
    public partial class frmLogin : Form, ILoginView
    {
        public string EmpID { get { return txtUsername.Text.Trim(); } }

        public string Password { get { return txtPassword.Text.Trim(); } }

        //The Presenter
        private LoginPresenter _loginPresenter; 

        public frmLogin() {
            InitializeComponent();
            _loginPresenter = new LoginPresenter(this);
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
            Hide();
            bool isValid = _loginPresenter.Login();
            Show();

            //clear text boxes
            txtUsername.Text = "";
            txtPassword.Text = "";

            if(!isValid)
            {
                MessageBox.Show("Username or Password is not correct.", "Invalid Account", MessageBoxButtons.OK);
            }
        }
    }
}
