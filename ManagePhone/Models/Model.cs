using ActionService;
using AutoMapper;
using BusinessObjects;
using ManagePhone.Models.Models;
using System.Collections.Generic;
using System.Security.Policy;

namespace ManagePhone.Models
{
    public class Model : IModel
    {
        private static Service service = new Service();

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
            Mapper.CreateMap<TblOrder, OrderModel>();
            Mapper.CreateMap<OrderModel, TblOrder>();
        }

        #region Role

        public RoleModel GetRole(int RoleID)
        {
            var Role = service.GetRoleByRoleID(RoleID);
            return Mapper.Map<TblRole, RoleModel>(Role);
        }

        #endregion Role

        #region Login / Logout

        public EmployeeModel CheckLogin(string EmpID, string Password)
        {
            var Employee = service.CheckLogin(EmpID, Password);
            return Mapper.Map<TblEmployee, EmployeeModel>(Employee);
        }

        public void Logout()
        {
        }

        #endregion Login / Logout

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

        public CustomerModel SearchCustomerByPhone(string Phone)
        {
            var Customer = service.SearchCustomerByPhone(Phone);
            return Mapper.Map<TblCustomer, CustomerModel>(Customer);
        }
        #endregion Customer

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

        #endregion Employee

        #region Products

        public bool AddProduct(ProductModel model)
        {
            var Product = Mapper.Map<ProductModel, TblProducts>(model);
            return service.AddProduct(Product);
        }

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
                ProductModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
            }
            return ProductModelList;
        }

        public ProductModel GetProduct(int ProductID)
        {
            var Product = service.GetProduct(ProductID);
            return Mapper.Map<TblProducts, ProductModel>(Product);
        }

        public void UpdateProductQuantity(int ProductID, int NewQuantity)
        {
            service.UpdateProductQuantity(ProductID, NewQuantity);
        }
        
        public bool UpdateProduct(ProductModel model)
        {
            var Product = Mapper.Map<ProductModel, TblProducts>(model);
            return service.UpdateProduct(Product);
        }

        public List<ProductModel> SearchProductsByNameOrBrand(string ProductName, string Brand)
        {
            var TblProductNameList = service.SearchProductsByNameOrBrand(ProductName, Brand);
            List<ProductModel> ProductModelList = new List<ProductModel>();
            foreach (var item in TblProductNameList)
            {
                ProductModelList.Add(Mapper.Map<TblProducts, ProductModel>(item));
            }
            return ProductModelList;
        }

        #endregion Products

        #region Order
        public bool AddOrder(OrderModel Model)
        {
            var Order = Mapper.Map<OrderModel, TblOrder>(Model);
            return service.AddOrder(Order);
        }

        public OrderModel GetLastestOrder(int CustomerID)
        {
            var Order = service.GetLastestOrder(CustomerID);
            return Mapper.Map<TblOrder, OrderModel>(Order);
        }
        #endregion

        #region OrderDetail
        public bool AddOrderDetail(string orderID, int productID, int quantity, long price)
        {
            return service.AddItemToOrder(orderID, productID, quantity, price);
        }        
        #endregion
    }
}