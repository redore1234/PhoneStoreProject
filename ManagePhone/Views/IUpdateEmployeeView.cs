﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IUpdateEmployeeView : IView
    {
        string Username { get; set; }
        string NewPassword { get; }
        string ConfirmPassword { get; }
        string EmployeeName { get; set; }
        string Address { get; set; }
        DateTime DOB { get; set; }
        string Phone { get; set; }
        bool IsManager { get; set; }
    }
}
