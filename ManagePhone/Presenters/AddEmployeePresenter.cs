using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class AddEmployeePresenter : Presenter<IAddEmployeeView>
    {
        //Constructor
        public AddEmployeePresenter(IAddEmployeeView view) : base(view)
        {
        }

        //perform add employee
        public void AddEmployee()
        {
            string EmployeeID = View.Username;
            string Password = View.Password;
            string Name = View.Name;
            string Address = View.Address;
            DateTime DOB = View.DOB;
            string Phone = View.Phone;
            int IsManager = View.IsManager;

            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = EmployeeID,
                Password = Password,
                Name = Name,
                Address = Address,
                DOB = DOB,
                Phone = Phone,
                RoleID = IsManager,
            };

            bool result = Model.AddEmployee(employee);
        }
    }
}
