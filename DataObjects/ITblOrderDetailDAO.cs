using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblOrderDetailDAO
    {
        //Add Items to Order by OrderID
        bool AddItemsToOrder(int OrderID, List<TblOrderDetail> ItemsList);

        //Get all Items in an Order by OrderID
        List<TblOrderDetail> GetItemsByOrderID(int OrderID);
    }
}
