using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService
{
    public interface IService
    {
        #region Employee Repository

            TblEmployee CheckLogin(string username, string password);

            List<TblEmployee> SearchEmployeesByName(string EmployeeName);

            List<TblEmployee> GetListEmployees();

            bool AddEmployee(TblEmployee Employee);

            bool DeleteEmployee(int EmployeeID);

            bool UpdateEmployeeWithoutPassword(TblEmployee Employee);

            bool UpdateEmployeeWithPassword(TblEmployee Employee);
        #endregion

        #region Customer Repository

            TblCustomer SearchCustomerByPhone(string PhoneNumber);

            List<TblCustomer> SearchCustomersByName(string CustomerName);

            List<TblCustomer> GetListCustomers();

            bool AddCustomer(TblCustomer Customer);

            bool UpdateCustomer(TblCustomer Customer);

            bool DeleteCustomer(int CustomerID);

        #endregion

        #region Products Repository

            bool AddProduct(TblProducts Product);

            bool UpdateProduct(TblProducts Product);

            bool DeleteProduct(int ProductID);

            TblProducts GetProduct(int ProductID);

            List<TblProducts> GetListProducts();

            List<TblProducts> SearchProducts(string ProductName);

        #endregion

        #region Order Repository

            List<TblOrder> GetListOrders();

            TblOrder SearchOrder(string OrderID);

            bool DeleteOrder(string OrderID);

            bool AddOrder(TblOrder Order);

        #endregion

        #region OrderDetail Repository

            bool AddItemsToOrder(int OrderID, List<TblOrderDetail> ItemsList);

            List<TblOrderDetail> GetItemsByOrderID(int OrderID);

        #endregion

        #region Brand Repository

            List<TblBrand> GetListBrands();

            string GetBrandByBrandID(int BrandID);

        #endregion

        #region Rank Repository

            int GetRankIDByName(string RankName);

        #endregion

        #region Role Repository

            TblRole GetRoleByRoleID(int RoleID);

        #endregion
    }
}
