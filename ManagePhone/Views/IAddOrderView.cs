using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IAddOrderView : IView
    {
        string CustomerPhone { get; }
        string ProductName { get; }
        IList<ProductModel> ListProduct { set; }
        IList<CartItemModel> Cart { get; set; }
        CustomerModel Customer { get; set; }
    }
}
