using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IEmployeeMainView
    {
        string CustomerPhone { get; }
        string ProductName { get; set; }
    }
}
