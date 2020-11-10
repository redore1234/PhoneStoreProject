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
    }
}
