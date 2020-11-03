using ManagePhone.Models;
using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class LoginPresenter: Presenter<ILoginView>
    {
        //Constructor
        public LoginPresenter(ILoginView view)
            :base(view) {}

        //Perform login. Gets data from view and calls model.
        public bool Login()
        {
            string EmpID = View.EmpID;
            string Password = View.Password;
            int RoleID;
            bool IsValid = false;

            EmployeeModel Employee = Model.CheckLogin(EmpID, Password);
            
            if(Employee != null)
            {
                RoleID = Employee.RoleID;
                RoleModel Role = Model.GetRole(RoleID);

                string RoleName = Role.RoleName;

                switch (RoleName)
                {
                    case "Manager":
                        frmManager frmManager = new frmManager(Employee);
                        frmManager.ShowDialog();
                        break;
                    case "Employee":
                        frmEmployee frmEmployee = new frmEmployee();
                        frmEmployee.ShowDialog();
                        break;
                }
                IsValid = true;
            }

            return IsValid;
        }
    }
}
