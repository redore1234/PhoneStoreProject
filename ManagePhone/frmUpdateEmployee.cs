using ManagePhone.Models.Models;
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
    public partial class frmUpdateEmployee : Form, IUpdateEmployeeView {

        EmployeeModel EmployeeModel;

        //The presenter
        private UpdateEmployeePresenter _updateEmployeePresenter;

        public string Username { 
            get { return txtUsername.Text.Trim(); }
            set { txtUsername.Text = value; }
        }

        public string NewPassword { 
            get { return txtNewPassword.Text.Trim(); } 
        }

        public string ConfirmPassword { 
            get { return txtConfirmPassword.Text.Trim(); } 
        }
        
        public string EmployeeName { 
            get { return txtEmployeeName.Text.Trim(); }
            set { txtEmployeeName.Text = value; } 
        }

        public string Address { 
            get { return txtEmployeeAddress.Text.Trim(); }
            set { txtEmployeeAddress.Text = value; } 
        }
        
        public string Phone { 
            get {return txtEmployeePhone.Text.Trim(); }
            set {txtEmployeePhone.Text = value; } 
        }
        
        public bool IsManager { 
            get { return chkbManager.Checked; } 
            set { chkbManager.Checked = value; } 
        }

        public DateTime DOB
        {
            get { return dtpDOB.Value; }
            set { dtpDOB.Value = value; }
        }

        public frmUpdateEmployee() {
            InitializeComponent();
            _updateEmployeePresenter = new UpdateEmployeePresenter(this);
        }

        public frmUpdateEmployee(EmployeeModel Model): this()
        {
            EmployeeModel = Model;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            bool IsCloseForm = _updateEmployeePresenter.UpdateEmployee();
            if(IsCloseForm)
            {
                this.Close();
            }
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            //Customize DOB field to dd-MM-yyyy
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "dd-MM-yyyy";

            //When form load, call Display method from Presenter
            _updateEmployeePresenter.Display(EmployeeModel);
        }
    }
}
