using ManagePhone.Models.Models;
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
	    public bool AddCustomer(CustomerModel customer);
        public bool UpdateCustomer(CustomerModel customer);
        public bool DeleteCustomer(int cusID);
        public bool AddEmployee(EmployeeModel employee);
        public bool UpdateEmployee(EmployeeModel employee);
        public bool DeleteEmployee(string empID);
        public List<CustomerModel> LoadCustomerList();
        public List<EmployeeModel> LoadEmployeeList();
    }
}
