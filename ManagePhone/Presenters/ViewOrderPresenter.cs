using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManagePhone.Presenters
{
    public class ViewOrderPresenter : Presenter<IOrderView>
    {
        public ViewOrderPresenter(IOrderView view) : base(view)
        {
            LoadOrders();
        }

        public void LoadOrders()
        {
            List<OrderModel> OrderList = Model.GetOrdersList();
            View.OrderList = OrderList;
        }

        public void SearchOrder()
        {
            string OrderID = View.OrderID;
            List<OrderModel> OrderList = Model.SearchOrder(OrderID);
            View.OrderList = OrderList;
        }

        public void DeleteOrder(string OrderID)
        {
            bool DeleteSuccess = Model.DeleteOrder(OrderID);
            if (DeleteSuccess)
            {
                bool Result = Model.DeleteOrderDetail(OrderID);
                if (Result)
                {
                    MessageBox.Show("Deleted Successfully", "Notice");
                    LoadOrders();
                }
            }
        }
    }
}
