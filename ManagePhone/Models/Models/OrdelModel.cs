using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models.Models
{

    public class OrdelModel
    {
        public string OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string EmployeeID { get; set; }
        public long TotalPrice { get; set; }
        public IList<OrderDetailModel> Order { get; set; }
    }
}
