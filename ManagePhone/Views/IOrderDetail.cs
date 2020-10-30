using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IOrderDetail : IView
    {
        string OrderID { set; }
        //IList<OrderDetailModel> OrderDetails { set; }
    }
}
