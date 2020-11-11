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

namespace ManagePhone.GUI {
    public partial class frmAddCustomer : Form, IAddCustomerView
    {
        public string CustomerName => txtCustomerName.Text;
        public DateTime DOB => dtCustomerDOB.Value;
        public string Phone
        {
            get => txtCustomerPhone.Text;
            set => txtCustomerPhone.Text = value;
        }
        public string Address => txtCustomerAddress.Text;

        //The presenter
        private AddCustomerPresenter _addCustomerPresenter;
        public frmAddCustomer() {
            InitializeComponent();
            this.dtCustomerDOB.Format = DateTimePickerFormat.Custom;
            dtCustomerDOB.CustomFormat = "dd-MM-yyyy";

            _addCustomerPresenter = new AddCustomerPresenter(this);
        }

        public frmAddCustomer(string Phone) : this()
        {
            this.Phone = Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _addCustomerPresenter.AddCustomer();
            Close();
        }
    }
}
