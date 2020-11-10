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
    public partial class frmViewOrder : Form, IOrderView 
    {
        public string OrderID 
        { 
            get => txtOrderID.Text; 
        }
        public IList<OrderModel> OrderList 
        {
            set
            {
                LoadData((List<OrderModel>)value);
            }
        }

        //the presenter
        ViewOrderPresenter _viewOrderPresenter;
        public frmViewOrder()
        {
            InitializeComponent();
            _viewOrderPresenter = new ViewOrderPresenter(this);
        }

        private void LoadData(List<OrderModel> OrderList)
        {
            dgvListOrder.DataSource = OrderList;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmViewOrderDetails viewOrderDetails = new frmViewOrderDetails();
            this.Hide();
            viewOrderDetails.ShowDialog();
            //this.Close();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            _viewOrderPresenter.SearchOrder();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            OrderModel OrderModel = (OrderModel)dgvListOrder.CurrentRow.DataBoundItem;
            _viewOrderPresenter.DeleteOrder(OrderModel.OrderID);
        }
    }
}
