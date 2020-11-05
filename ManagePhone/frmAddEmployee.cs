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
        public bool IsManager => cbManager.Checked;

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
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Field username can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Field password can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmployeePhone.Text))
            {
                MessageBox.Show("Field phone can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("Field name can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmployeeAddress.Text))
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