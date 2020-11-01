using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class ViewEmployeePresenter : Presenter<IEmployeesView>
    {
        //constructor
        public ViewEmployeePresenter(IEmployeesView view) : base(view)
        {
        }

        //Delete the employee
        public void DeleteEmployee()
        {
            string EmpID = View.EmployeeID;

            bool result = Model.DeleteEmployee(EmpID);
        }
    }
}
