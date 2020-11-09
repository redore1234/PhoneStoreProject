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
        #region Login
            EmployeeModel CheckLogin(string EmpID, string Password);
            RoleModel GetRole(int roleID);
        #endregion

        #region Employee
            public bool AddEmployee(EmployeeModel employee);
            public bool UpdateEmployeeWithoutPassword(EmployeeModel employee);
            public bool UpdateEmployeeWithPassword(EmployeeModel employee);
            public bool DeleteEmployee(string empID);
            public List<EmployeeModel> SearchEmployeesByName(string EmployeeName);
            public List<EmployeeModel> LoadEmployeeList();
        #endregion

        #region Customer
            public bool AddCustomer(CustomerModel customer);
            public bool UpdateCustomer(CustomerModel customer);
            public List<CustomerModel> LoadCustomerList();
            public List<CustomerModel> SearchCustomer(string name, string phone);
        #endregion

        #region Products
            public bool AddProduct(ProductModel Product);
            public bool DeleteProduct(int ProductID);
            public List<ProductModel> SearchProducts(string ProductName);
            public List<ProductModel> LoadProductList();
            public CustomerModel SearchCustomerByPhone(string Phone);
        #endregion

    }
}
