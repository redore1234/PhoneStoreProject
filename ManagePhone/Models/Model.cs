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
            Mapper.CreateMap<TblProducts, ProductModel>();
            Mapper.CreateMap<ProductModel, TblProducts>();
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
        public List<CustomerModel> LoadCustomerList()
        {
            var TblCustomerList = service.GetListCustomers();
            List<CustomerModel> CustomerModelList = new List<CustomerModel>();
            foreach (var item in TblCustomerList)
            {
                CustomerModelList.Add(Mapper.Map<TblCustomer, CustomerModel>(item));
            }
            return CustomerModelList;
        }

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

        public List<CustomerModel> SearchCustomer(string Name, string Phone)
        {
            var TblCustomerList = service.SearchCustomers(Name, Phone);

            //mapping TblCustomer to CustomerModel
            List<CustomerModel> CustomerModelList = new List<CustomerModel>();
            foreach (var item in TblCustomerList)
            {
                CustomerModelList.Add(Mapper.Map<TblCustomer, CustomerModel>(item));
            }
            return CustomerModelList;
        }
        #endregion

        #region Employee
        public bool AddEmployee(EmployeeModel model)
        {
            var employee = Mapper.Map<EmployeeModel, TblEmployee>(model);
            return service.AddEmployee(employee);
        }

        public bool DeleteEmployee(string empID)
        {
            return service.DeleteEmployee(empID);
        }

        public List<EmployeeModel> LoadEmployeeList()
        {
            var TblEmployeeList = service.GetListEmployees();
            List<EmployeeModel> EmployeeModelList = new List<EmployeeModel>();
            foreach (var item in TblEmployeeList)
            {
                EmployeeModelList.Add(Mapper.Map<TblEmployee, EmployeeModel>(item));
            }

            return EmployeeModelList;
        }

        public List<EmployeeModel> SearchEmployeesByName(string EmployeeName)
        {
            var TblEmployeesNameList = service.SearchEmployeesByName(EmployeeName);
            List<EmployeeModel> EmployeeModelList = new List<EmployeeModel>();
            foreach (var item in TblEmployeesNameList)
            {
                EmployeeModelList.Add(Mapper.Map<TblEmployee, EmployeeModel>(item));
            }
            return EmployeeModelList;
        }

        public bool UpdateEmployeeWithoutPassword(EmployeeModel model)
        {
            var employee = Mapper.Map<EmployeeModel, TblEmployee>(model);
            return service.UpdateEmployeeWithoutPassword(employee);
        }

        public bool UpdateEmployeeWithPassword(EmployeeModel model)
        {
            var employee = Mapper.Map<EmployeeModel, TblEmployee>(model);
            return service.UpdateEmployeeWithPassword(employee);
        }
        #endregion

        #region Products
            public bool DeleteProduct(int proID)
            {
                return service.DeleteProduct(proID);
            }

            public List<ProductModel> SearchProducts(string ProductName)
            {
                var TblProductNameList = service.SearchProducts(ProductName);
                List<ProductModel> ProductModelList = new List<ProductModel>();
                foreach (var item in TblProductNameList)
                {
                    //ProductModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
                ProductModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
            }
                return ProductModelList;
            }

            public List<ProductModel> LoadProductList()
            {
                var TblProductList = service.GetListProducts();
                List<ProductModel> ProductModelList = new List<ProductModel>();
                foreach (var item in TblProductList)
                {
                    //ProductsModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
                ProductModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
                }
                return ProductModelList;
            }

        #endregion
    }
}
