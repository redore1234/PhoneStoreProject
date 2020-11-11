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
    public partial class frmViewEmployee : Form, IEmployeesView {

        public string EmployeeName
        {
            get => txtSearchEmployeeName.Text;
        }

        public EmployeeModel CurEmployeeModel;
        public IList<EmployeeModel> EmployeeList
        {
            set
            {
                var EmployeeList = value;
                BindingData(EmployeeList);
            }
        }

        //The presenter
        ViewEmployeePresenter _viewEmployeePresenter;

        public frmViewEmployee() {
            InitializeComponent();
            _viewEmployeePresenter = new ViewEmployeePresenter(this);
        }

        public frmViewEmployee(EmployeeModel emp):this() 
        {
            CurEmployeeModel = emp;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            this.Hide();
            EmployeeModel EmployeeModel = (EmployeeModel) dgvListEmployee.CurrentRow.DataBoundItem;
            _viewEmployeePresenter.UpdateEmployee(EmployeeModel);
            this.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e) {
            EmployeeModel EmployeeModel = (EmployeeModel)dgvListEmployee.CurrentRow.DataBoundItem;

            _viewEmployeePresenter.DeleteEmployee(EmployeeModel);
            _viewEmployeePresenter.LoadEmployees();
            
        }

        private void btnCancelEmployee_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BindingData(IList<EmployeeModel> EmployeeList)
        {
            dgvListEmployee.DataSource = EmployeeList;
        }

        private void txtSearchEmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (EmployeeName == null || EmployeeName.Equals(""))
            {
                _viewEmployeePresenter.LoadEmployees();
            } else
            {
                _viewEmployeePresenter.SearchEmployee(EmployeeName);
            }
        }
    }
}
