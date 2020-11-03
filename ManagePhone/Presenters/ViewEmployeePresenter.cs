using ManagePhone.Models.Models;
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
        public void DeleteEmployee(EmployeeModel emp)
        {
            string EmpID = View.EmployeeID;

            bool result = Model.DeleteEmployee(EmpID);
            if (!EmpID.Equals(emp.EmployeeID))
            {
                if (result)
                {
                    MessageBox.Show("Employee Deleted!", "Notify");
                }
            }
        }


        //Load list employee
        public void LoadEmployees()
        {
            View.EmployeeList = Model.LoadEmployeeList();
        }
    }
}
