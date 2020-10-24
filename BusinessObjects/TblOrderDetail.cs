using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblOrderDetail : BusinessObject
    {
        public int OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public long ItemPrice { get; set; }

        // ** Enterprise Design Pattern: Foreign Key Mapping. TblCustomer, TblEmployee are the parents
        public TblOrder TblOrder { get; set; }
        public TblProducts TblProducts { get; set; }
    }
}
