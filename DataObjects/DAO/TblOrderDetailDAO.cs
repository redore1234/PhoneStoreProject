using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblOrderDetailDAO : ITblOrderDetailDAO
    {
        static Db db = new Db();

        static Func<IDataReader, TblOrderDetail> Make = reader =>
        new TblOrderDetail
        {
            ProductID = int.Parse(reader["productID"].ToString()),
            ItemPrice = long.Parse(reader["itemPrice"].ToString()),
            Quantity = int.Parse(reader["quantity"].ToString())
        };

        public bool AddItemsToOrder(string OrderID, int ProductID, int Quantity, long Price)
        {
            string StoreProc = "spAddOrderDetail";
            object[] parms =
            {
                "@OrderID" , OrderID,
                "@ProductID", ProductID,
                "@Quantity", Quantity,
                "@Price", Price
            };
            return db.Update(StoreProc, parms) > 0;
        }

        public bool DeleteOrderDetails(string OrderID)
        {
            string StoreProc = "spDeleteOrderDetail";
            object[] parms =
            {
                "@OrderID" , OrderID
            };
            return db.Update(StoreProc, parms) > 0;
        }

        public List<TblOrderDetail> GetItemsByOrderID(string OrderID)
        {
            string StoreProc = "spGetItemsByOrderID";
            object[] parms =
            {
                "@OrderID", OrderID
            };
            return db.Read(StoreProc, Make, parms).ToList();
        }
    }
}
