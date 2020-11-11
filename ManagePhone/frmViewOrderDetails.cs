using ManagePhone.Models.Models;
using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmViewOrderDetails : Form, IOrderDetailView
    {
        //The presenter
        private ViewOrderDetailsPreseneter _viewOrderDetailsPreseneter;

        public List<OrderDetailModel> OrderDetailList
        {
            set => dgvListOrderItem.DataSource = value;
        }

        private string OrderID;

        public frmViewOrderDetails()
        {
            InitializeComponent();
        }

        public frmViewOrderDetails(string OrderID) : this()
        {
            this.OrderID = OrderID;
            _viewOrderDetailsPreseneter = new ViewOrderDetailsPreseneter(this);
            Text = "Order detail of " + OrderID;
        }

        private void frmViewOrderDetails_Load(object sender, EventArgs e)
        {
            _viewOrderDetailsPreseneter.ShowOrderDetails(OrderID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}