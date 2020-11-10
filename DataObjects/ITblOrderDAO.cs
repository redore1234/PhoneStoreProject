using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObjects
{
    public interface ITblOrderDAO
    {
        //Get All Order
        List<TblOrder> GetListOrders();

        //Search Order
        TblOrder SearchOrder(string OrderID);

        //Delete Order
        bool DeleteOrder(string OrderID);

        //Add Order
        bool AddOrder(TblOrder Order);

        //Get lastest insert Order using customer id
        TblOrder GetLastestOrder(int CustomerID);

    }
}
