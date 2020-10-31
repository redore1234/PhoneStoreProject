using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataObjects.DAO;

namespace ActionService
{
    public class Service : IService
    {
        static readonly ITblEmployeeDAO tblEmployeeDAO = new TblEmployeeDAO();
        static readonly ITblCustomerDAO tblCustomerDAO = new TblCustomerDAO();
        static readonly ITblRoleDAO tblRoleDAO = new TblRoleDAO();
        public bool AddCustomer(TblCustomer Customer)
        {
            return tblCustomerDAO.AddCustomer(Customer);
        }

        public bool AddEmployee(TblEmployee Employee)
        {
            return tblEmployeeDAO.AddEmployee(Employee);
        }

        public bool AddItemsToOrder(int OrderID, List<TblOrderDetail> ItemsList)
        {
            throw new NotImplementedException();
        }

        public bool AddOrder(TblOrder Order)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(TblProducts Product)
        {
            throw new NotImplementedException();
        }

        public TblEmployee CheckLogin(string username, string password)
        {
            return tblEmployeeDAO.CheckLogin(username, password);
        }

        public bool DeleteCustomer(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int EmployeeID)
        {
            return tblEmployeeDAO.DeleteEmployee(EmployeeID);
        }

        public bool DeleteOrder(string OrderID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int ProductID)
        {
            throw new NotImplementedException();
        }

        public string GetBrandByBrandID(int BrandID)
        {
            throw new NotImplementedException();
        }

        public List<TblOrderDetail> GetItemsByOrderID(int OrderID)
        {
            throw new NotImplementedException();
        }

        public List<TblBrand> GetListBrands()
        {
            throw new NotImplementedException();
        }

        public List<TblCustomer> GetListCustomers()
        {
            throw new NotImplementedException();
        }

        public List<TblEmployee> GetListEmployees()
        {
            return tblEmployeeDAO.GetListEmployees();
        }

        public List<TblOrder> GetListOrders()
        {
            throw new NotImplementedException();
        }

        public List<TblProducts> GetListProducts()
        {
            throw new NotImplementedException();
        }

        public TblProducts GetProduct(int ProductID)
        {
            throw new NotImplementedException();
        }

        public int GetRankIDByName(string RankName)
        {
            throw new NotImplementedException();
        }

        public TblRole GetRoleByRoleID(int RoleID)
        {
            return tblRoleDAO.GetRoleByRoleID(RoleID);
        }

        public int GetStatusIDByStatus(string StatusName)
        {
            throw new NotImplementedException();
        }

        public TblCustomer SearchCustomerByPhone(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<TblCustomer> SearchCustomersByName(string CustomerName)
        {
            throw new NotImplementedException();
        }

        public List<TblEmployee> SearchEmployeesByName(string EmployeeName)
        {
            return tblEmployeeDAO.SearchEmployeesByName(EmployeeName);
        }

        public TblOrder SearchOrder(string OrderID)
        {
            throw new NotImplementedException();
        }

        public List<TblProducts> SearchProducts(string ProductName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(TblCustomer Customer)
        {
            return tblCustomerDAO.UpdateCustomer(Customer);
        }

        public bool UpdateEmployee(TblEmployee Employee)
        {
            return tblEmployeeDAO.UpdateEmployee(Employee);
        }

        public bool UpdateProduct(TblProducts Product)
        {
            throw new NotImplementedException();
        }
    }
}
