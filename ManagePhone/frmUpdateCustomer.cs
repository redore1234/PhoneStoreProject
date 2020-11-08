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
    public partial class frmUpdateCustomer : Form, IUpdateCustomerView
    {
        public CustomerModel customer;
        public int CustomerID
        {
            get => customer.CustomerID;
        }
        public DateTime DOB 
        { 
            get => dtDOB.Value;
            set => dtDOB.Value = value;
        }
        public string Phone 
        { 
            get => txtCustomerPhone.Text; 
            set => txtCustomerPhone.Text = value; 
        }
        public string Address 
        { 
            get => txtCustomerAddress.Text; 
            set => txtCustomerAddress.Text = value; 
        }
        public string CustomerName 
        { 
            get => txtCustomerName.Text; 
            set => txtCustomerName.Text = value; 
        }

        //the presenter 
        UpdateCustomerPresenter _updateCustomerPresenter;
        public frmUpdateCustomer() {
            InitializeComponent();
            _updateCustomerPresenter = new UpdateCustomerPresenter(this);
  
        }

        public frmUpdateCustomer(CustomerModel customer) : this()
        {
            this.customer = customer;
            //display data to textboxes
            DOB = customer.DOB;
            CustomerName = customer.Name;
            Address = customer.Address;
            Phone = customer.Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            _updateCustomerPresenter.UpdateCustomer();
            Close();
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            dtDOB.Format = DateTimePickerFormat.Custom;
            dtDOB.CustomFormat = "dd-MM-yyyy";
        }
    }
}
