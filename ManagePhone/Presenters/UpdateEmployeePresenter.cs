using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class UpdateEmployeePresenter : Presenter<IUpdateEmployeeView>
    {
        //constructor
        public UpdateEmployeePresenter(IUpdateEmployeeView view) : base(view)
        {
        }

        //Update the Employee
        public void UpdateEmployee()
        {
            string OldPassword = View.OldPassword;
            string NewPassword = View.NewPassword;
            string Name = View.Name;
            string Address = View.Address;
            DateTime DOB = View.DOB;
            string Phone = View.Phone;
            int IsManager = View.IsManager;

            EmployeeModel employee = new EmployeeModel()
            {
                Password = NewPassword,
                Name = Name,
                Address = Address,
                DOB = DOB,
                Phone = Phone,
                RoleID = IsManager,
            };

            bool result = Model.UpdateEmployee(employee);
        }
    }
}
