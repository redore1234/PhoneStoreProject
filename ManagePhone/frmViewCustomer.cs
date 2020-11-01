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
        public int CustomerID { get; set; }
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

            //clear binding data textboxes
            txtPhone.DataBindings.Clear();
            txtSearchCustomerName.DataBindings.Clear();

            //binding data to textboxes
            txtPhone.DataBindings.Add("Text", CustomerList, "Phone");
            txtSearchCustomerName.DataBindings.Add("Text", CustomerList, "Name");
        }


        private void btnCancelCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e) {
            CustomerModel customer = (CustomerModel) dgvListCustomer.CurrentRow.DataBoundItem;
            (new frmUpdateCustomer(customer)).ShowDialog();
            _viewCustomerPresenter.LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            _viewCustomerPresenter.DeleteCustomer();
            _viewCustomerPresenter.LoadCustomers();
        }

        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            CustomerID = int.Parse(dgvListCustomer[0, row].Value.ToString());
        }
    }
}
