using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataObjects.DAO;
using System.Diagnostics;

namespace ActionService
{
    public class Service : IService
    {
        static readonly ITblEmployeeDAO tblEmployeeDAO = new TblEmployeeDAO();
        static readonly ITblCustomerDAO tblCustomerDAO = new TblCustomerDAO();
        static readonly ITblRoleDAO tblRoleDAO = new TblRoleDAO();
        static readonly ITblProductsDAO tblProductsDAO = new TblProductsDAO();
        static readonly ITblOrderDAO tblOrderDAO = new TblOrderDAO();
        static readonly ITblOrderDetailDAO tblOrderDetailDAO = new TblOrderDetailDAO();

        public bool AddCustomer(TblCustomer Customer)
        {
            return tblCustomerDAO.AddCustomer(Customer);
        }

        public bool AddEmployee(TblEmployee Employee)
        {
            return tblEmployeeDAO.AddEmployee(Employee);
        }

        public bool AddItemToOrder(string OrderID, int ProductID, int Quantity, long Price)
        {
            return tblOrderDetailDAO.AddItemsToOrder(OrderID, ProductID, Quantity, Price);
        }

        public bool AddOrder(TblOrder Order)
        {
            return tblOrderDAO.AddOrder(Order);
        }

        public bool AddProduct(TblProducts Product)
        {
            return tblProductsDAO.AddProduct(Product);
        }

        public TblEmployee CheckLogin(string username, string password)
        {
            return tblEmployeeDAO.CheckLogin(username, password);
        }

        public bool DeleteEmployee(string EmployeeID)
        {
            return tblEmployeeDAO.DeleteEmployee(EmployeeID);
        }

        public bool DeleteOrder(string OrderID)
        {
            return tblOrderDAO.DeleteOrder(OrderID);
        }

        public bool DeleteProduct(int ProductID)
        {
            return tblProductsDAO.DeleteProduct(ProductID);
        }

        public List<TblOrderDetail> GetItemsByOrderID(string OrderID)
        {
            return tblOrderDetailDAO.GetItemsByOrderID(OrderID);
        }

        public List<TblCustomer> GetListCustomers()
        {
            return tblCustomerDAO.GetListCustomers();
        }

        public List<TblEmployee> GetListEmployees()
        {
            return tblEmployeeDAO.GetListEmployees();
        }

        public List<TblOrder> GetListOrders()
        {
            return tblOrderDAO.GetListOrders();
        }

        public List<TblProducts> GetListProducts()
        {
            return tblProductsDAO.GetListProducts();
        }

        public TblProducts GetProduct(int ProductID)
        {
            return tblProductsDAO.GetProduct(ProductID);
        }

        public TblRole GetRoleByRoleID(int RoleID)
        {
            return tblRoleDAO.GetRoleByRoleID(RoleID);
        }

        public List<TblCustomer> SearchCustomers(string CustomerName, string Phone)
        {
            return tblCustomerDAO.SearchCustomers(CustomerName, Phone);
        }

        public TblCustomer SearchCustomerByPhone(string Phone)
        {
            return tblCustomerDAO.SearchCustomerByPhone(Phone);
        }

        public List<TblEmployee> SearchEmployeesByName(string EmployeeName)
        {
            return tblEmployeeDAO.SearchEmployeesByName(EmployeeName);
        }

        public List<TblOrder> SearchOrder(string OrderID)
        {
            return tblOrderDAO.SearchOrder(OrderID);
        }

        public List<TblProducts> SearchProducts(string ProductName)
        {
            return tblProductsDAO.SearchProducts(ProductName);
        }

        public bool UpdateCustomer(TblCustomer Customer)
        {
            return tblCustomerDAO.UpdateCustomer(Customer);
        }

        public bool UpdateEmployeeWithoutPassword(TblEmployee Employee)
        {
            return tblEmployeeDAO.UpdateEmployeeWithoutPassword(Employee);
        }

        public bool UpdateEmployeeWithPassword(TblEmployee Employee)
        {
            return tblEmployeeDAO.UpdateEmployeeWithPassword(Employee);
        }

        public bool UpdateProduct(TblProducts Product)
        {
            return tblProductsDAO.UpdateProduct(Product);
        }

        public List<TblProducts> SearchProductsByNameOrBrand(string ProductName, string Brand)
        {
            return tblProductsDAO.SearchProductsNameOrBrand(ProductName, Brand);
        }

        public TblOrder GetLastestOrder(int CustomerID)
        {
            return tblOrderDAO.GetLastestOrder(CustomerID);
        }

        public void UpdateProductQuantity(int ProductID, int NewQuantity)
        {
            tblProductsDAO.UpdateQuantity(ProductID, NewQuantity);
        }

        public string GetProductNameById(int ProductID)
        {
            return tblProductsDAO.GetProductNameByID(ProductID);
        }
        
        public bool DeleteOrderDetail(string OrderID)
        {
            return tblOrderDetailDAO.DeleteOrderDetails(OrderID);
        }
    }
}
