﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IEmployeesView : IView
    {
        string Name { get; set; }
        //IList<EmployeeModel> Employees { set; }
    }
}
