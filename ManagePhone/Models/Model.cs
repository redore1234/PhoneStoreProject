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
        }

        #region Login / Logout
        public bool Login(string username, string password)
        {
            return true;
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
    }
}
