using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblOrder : BusinessObject
    {
        public string OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string EmployeeID { get; set; }
        public long TotalPrice { get; set; }

        // ** Enterprise Design Pattern: Foreign Key Mapping. TblCustomer, TblEmployee are the parents
        public TblCustomer TblCustomer { get; set; }
        public TblEmployee TblEmployee { get; set; }
    }
}
