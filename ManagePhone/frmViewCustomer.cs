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
    public partial class frmViewCustomer : Form, ICustomersView {
        public string CustomerName 
        { 
            get => txtSearchCustomerName.Text;
        }
        public string Phone 
        { 
            get => txtPhone.Text;
        }
        public IList<CustomerModel> CustomerList
        {
            set {
                var CustomerList = value;
                BindingData(CustomerList);
            }
        }

        //The presenter
        ViewCustomerPresenter _viewCustomerPresenter;

        public frmViewCustomer()
        {
            InitializeComponent();
            _viewCustomerPresenter = new ViewCustomerPresenter(this);
        } 

        private void BindingData(IList<CustomerModel> CustomerList)
        {
            dgvListCustomer.DataSource = CustomerList;
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e) {
            if (dgvListCustomer.Rows.Count != 0)
            {
                CustomerModel customer = (CustomerModel)dgvListCustomer.CurrentRow.DataBoundItem;
                _viewCustomerPresenter.UpdateCustomer(customer);
                _viewCustomerPresenter.LoadCustomers();
            }
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            _viewCustomerPresenter.SearchCustomer();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            _viewCustomerPresenter.SearchCustomer();
        }
    }
}
