using ManagePhone.GUI;
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
    public partial class frmManager : Form, IManagerView{
        public EmployeeModel CurEmployeeModel;


        // The presenter 
        ManagerPresenter _managerPresenter;

        public frmManager() {
            InitializeComponent();
            //Set custom format for DateTimePicker
            /* this.dtEmployeeDOB.Format = DateTimePickerFormat.Custom;
            this.dtPhoneYear.Format = DateTimePickerFormat.Custom;

            this.dtEmployeeDOB.CustomFormat = "dd-MM-yyyy";
            this.dtPhoneYear.CustomFormat = "dd-MM-yyyy";*/
            _managerPresenter = new ManagerPresenter(this);
        }

        public frmManager(EmployeeModel emp):this()
        {
            CurEmployeeModel = emp;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickAddEmployee();
            this.Show();
        }

        private void pbViewEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickViewEmployee(CurEmployeeModel);
            this.Show();
        }

        private void pbAddPhone_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickAddPhone();
            this.Show();
        }

        private void pbViewPhone_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickViewPhone();
            this.Show();
        }

        private void pbViewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickViewCustomer();
            this.Show();
        }

        private void pbViewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickViewOrder();
            this.Show();
        }

        private void pbAddOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            _managerPresenter.ClickAddOrder(CurEmployeeModel);
            this.Show();
        }
    }
}
