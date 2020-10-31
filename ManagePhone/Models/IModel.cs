﻿using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models
{
    public interface IModel
    {
        EmployeeModel CheckLogin(string EmpID, string Password);
        RoleModel GetRole(int roleID);
    }
}
