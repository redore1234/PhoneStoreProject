﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface ICustomersView : IView
    {
        int CustomerID { get; set; }
        string CustomerName { get; set; }
        string Phone { get; set; }
        //IList<CustomerModel> Customer { set; }
    }
}
