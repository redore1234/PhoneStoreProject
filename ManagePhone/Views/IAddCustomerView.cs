using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IAddCustomerView : IView
    {
        string CustomerName { get; }
        DateTime DOB { get; }
        string Phone { get; }
        string Address { get; }
    }
}
