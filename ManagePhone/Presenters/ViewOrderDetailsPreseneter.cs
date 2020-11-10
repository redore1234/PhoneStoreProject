using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    class ViewOrderDetailsPreseneter : Presenter<IOrderDetailView>
    {
        public ViewOrderDetailsPreseneter(IOrderDetailView view) : base(view) { }

        public void ShowOrderDetails(string OrderID)
        {
            View.OrderDetailList = Model.GetItemsByOrderID(OrderID);
        }
    }
}
