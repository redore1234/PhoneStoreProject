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

        public bool AddCustomer(TblCustomer Customer)
        {
            throw new NotImplementedException();
        }

        public bool AddEmployee(TblEmployee Employee)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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

        public int GetRoleIDByRole(string RoleName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(TblEmployee Employee)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(TblProducts Product)
        {
            throw new NotImplementedException();
        }
    }
}
