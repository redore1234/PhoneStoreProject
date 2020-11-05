using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface ICustomersView : IView
    {
        string CustomerName { get; }
        string Phone { get; }
        IList<CustomerModel> CustomerList { set; }
    }
}
