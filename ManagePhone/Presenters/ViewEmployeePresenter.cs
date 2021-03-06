﻿using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone.Presenters
{
    public class ViewEmployeePresenter : Presenter<IEmployeesView>
    {
        //constructor
        public ViewEmployeePresenter(IEmployeesView view) : base(view)
        {
            LoadEmployees();
        }

        //Delete the employee
        public void DeleteEmployee(EmployeeModel SelectedEmployee)
        {
            string EmpID = SelectedEmployee.EmployeeID;
            if (SelectedEmployee.RoleID != 1)
            {
                bool result = Model.DeleteEmployee(EmpID);

                if (result)
                {
                    MessageBox.Show("Employee Deleted!", "Notify");
                } 
            } else
            {
                MessageBox.Show("Delete Employee Fail!", "Notify");
            }
        }

        //Show Update Employee Dialog
        public void UpdateEmployee(EmployeeModel Model)
        {
            frmUpdateEmployee frmUpdateEmployee = new frmUpdateEmployee(Model);
            frmUpdateEmployee.ShowDialog();
            //After form closed, reload employee list
            LoadEmployees();
        }

        //Search Employee
        public void SearchEmployee(string name)
        {
            View.EmployeeList = Model.SearchEmployeesByName(name);

        }

        //Load list employee
        public void LoadEmployees()
        {
            View.EmployeeList = Model.LoadEmployeeList();
        }
    }
}
