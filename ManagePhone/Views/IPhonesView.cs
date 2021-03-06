﻿using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IPhonesView : IView
    {
        string Brand { get; }
        string Phone { get; }
        IList<ProductModel> ProductList { set; }
    }
}
