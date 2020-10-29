using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IOrderView
    {
        string OrderID { get; set; }
        //IList<OrderModel> Models { set; }
    }
}
