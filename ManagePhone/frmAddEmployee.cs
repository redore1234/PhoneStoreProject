using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmAddEmployee : Form, IAddEmployeeView
    {
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;
        public string EmployeeName => txtEmployeeName.Text;
        public string Address => txtEmployeeAddress.Text;
        public DateTime DOB => dtEmployeeDOB.Value;
        public string Phone => txtEmployeePhone.Text;
        public bool IsManager => chkbManager.Checked;

        //The presenter
        private AddEmployeePresenter _addEmployeePresenter;

        public frmAddEmployee()
        {
            InitializeComponent();
            _addEmployeePresenter = new AddEmployeePresenter(this);
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            dtEmployeeDOB.Format = DateTimePickerFormat.Custom;
            dtEmployeeDOB.CustomFormat = "dd-MM-yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Field username can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Field password can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Field phone can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(EmployeeName))
            {
                MessageBox.Show("Field name can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(Address))
            {
                MessageBox.Show("Field address can not empty!");
                return;
            }

            bool IsAddSuccess = _addEmployeePresenter.AddEmployee();
            if (IsAddSuccess)
            {
                this.Close();
            }
        }
    }
}