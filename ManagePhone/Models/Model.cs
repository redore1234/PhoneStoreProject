using ActionService;
using AutoMapper;
using BusinessObjects;
using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models
{
    public class Model : IModel
    {
        static Service service = new Service();

        static Model()
        {
            Mapper.CreateMap<TblEmployee, EmployeeModel>();
            Mapper.CreateMap<EmployeeModel, TblEmployee>();
            Mapper.CreateMap<TblCustomer, CustomerModel>();
            Mapper.CreateMap<CustomerModel, TblCustomer>();
            Mapper.CreateMap<TblRole, RoleModel>();
            Mapper.CreateMap<RoleModel, TblRole>();

        }

        #region Role
        public RoleModel GetRole(int RoleID)
        {
            var Role = service.GetRoleByRoleID(RoleID);
            return Mapper.Map<TblRole, RoleModel>(Role);
        }

        #endregion

        #region Login / Logout
        public EmployeeModel CheckLogin(string EmpID, string Password)
        {
            var Employee = service.CheckLogin(EmpID, Password);
            return Mapper.Map<TblEmployee, EmployeeModel>(Employee);
        }

        public void Logout()
        {

        }
        #endregion

        #region Customer
        public bool AddCustomer(CustomerModel model)
        {
            var customer = Mapper.Map<CustomerModel, TblCustomer>(model);
            return service.AddCustomer(customer);
        }

        public bool UpdateCustomer(CustomerModel model)
        {
            var customer = Mapper.Map<CustomerModel, TblCustomer>(model);
            return service.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(int cusID)
        {
            return service.DeleteCustomer(cusID);
        }
        #endregion

        #region Employee
        public bool AddEmployee(EmployeeModel model)
        {
            var employee = Mapper.Map<EmployeeModel, TblEmployee>(model);
            return service.AddEmployee(employee);
        }

        public bool UpdateEmployee(EmployeeModel model)
        {
            var employee = Mapper.Map<EmployeeModel, TblEmployee>(model);
            return service.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(int EmpID)
        {
            return service.DeleteEmployee(EmpID);
        }
        #endregion
    }
}
